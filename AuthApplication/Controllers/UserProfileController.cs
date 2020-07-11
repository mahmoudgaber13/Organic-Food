using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AuthApplication.Areas.Identity.Data;
using AuthApplication.Data;
using AuthApplication.Infrastructure;
using AuthApplication.Models;
using AuthApplication.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuthApplication.Controllers
{
    public class UserProfileController : Controller
    {
        private readonly AuthDBContext _context;
        private readonly IHttpContextAccessor HttpContextAccessor;
        private readonly UserManager<ApplicationUser> _userManger;
        private readonly SignInManager<ApplicationUser> _signInManger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment hostingEnvironment;
        public UserProfileController(AuthDBContext context,IHttpContextAccessor httpContextAccessor,
                                    UserManager<ApplicationUser> userManger,
                                    SignInManager<ApplicationUser> signInManger,
                                    IUnitOfWork unitOfWork,
                                    IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            HttpContextAccessor = httpContextAccessor;
            _userManger = userManger;
            _signInManger = signInManger;
            _unitOfWork = unitOfWork;
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            var UserId = HttpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            List<Order> orders = _context.orders.Where(o => o.UserID == UserId).ToList();
            ApplicationUser user = _context.Users.Find(UserId);
            ViewData["Orders"] = orders;
            return View(user);
        }

        public IActionResult GetOrderByLoggedInUser()
        {
            var UserId = HttpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            List<Order> orders = _context.orders.Where(o => o.UserID == UserId).ToList();
            var counter =orders.Count();
            return View(orders);
        }

        public IActionResult GetOrderDetailsById(int? id)
        {
            if(id == null) 
            {
                return BadRequest();
            }
            else
            {
                OrderDetails orderDetails = _context.OrderDetails.Where(o => o.OrderId == id).FirstOrDefault();
                return View(orderDetails);
            }
            
        }

        [HttpGet]
        public IActionResult Edit( )
        {
            var UserId = HttpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            if(UserId == null)
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                var user = _context.Users.Find(UserId);
                UserEditViewModel userModel = new UserEditViewModel
                {
                    Id=user.Id,
                    FirstName=user.FirstName,
                    LastName=user.LastName,
                    City=user.City,
                    Country=user.Country,
                    Email=user.Email,
                    Phone=user.Phone,
                    
                };
                if (userModel.ExistingPhotoPath != null)
                {
                    userModel.ExistingPhotoPath = user.ImagePath;
                }
                else
                {
                    user.ImagePath = "";
                }
                return View(userModel);
            }
            
        }


        [HttpPost]
        public async Task<IActionResult> Edit(string Id,UserEditViewModel userDetails,IFormFile file)
        {
            
            if (Id != userDetails.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    
                    var user = _context.Users.Find(Id);

                    user.FirstName = userDetails.FirstName;
                    user.LastName = userDetails.LastName;
                    user.City = userDetails.City;
                    user.Country = userDetails.Country;
                    user.PhoneNumber = userDetails.Phone;

                    if (file == null)
                    {
                        user.ImagePath = "";
                    }
                    else
                    {
                        _unitOfWork.UploadImage(file);
                        if (userDetails.ExistingPhotoPath != null)
                        {
                            string filePath = Path.Combine(hostingEnvironment.WebRootPath,
                                                "images", userDetails.ExistingPhotoPath);
                            System.IO.File.Delete(filePath);
                        }
                        user.ImagePath = file.FileName;
                    }
                    

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(userDetails.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(userDetails);
        }

        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManger.GetUserAsync(User);
                if (user == null)
                {
                    return RedirectToAction("Login", "Account");
                }

                var result = await _userManger.ChangePasswordAsync(
                                                user, model.CurrentPassword, model.NewPassword);
                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    return View();
                }
                await _signInManger.RefreshSignInAsync(user);
                return View("ChangePasswordConfirmation");
            }
            return View(model);
        }


        private bool UserExists(string id)
        {
            return _context.Users.Any(e => e.Id == id);
        }

        public IActionResult getAllUser()
        {
            var users = _context.Users.ToList();
            return View(users);
        }
        public void Active(string id)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);
            if (user.EmailConfirmed == true)
            {
                user.EmailConfirmed = false;
            }
            else
            {
                user.EmailConfirmed = true;
            }
            _context.SaveChanges();
        }
    }
}
