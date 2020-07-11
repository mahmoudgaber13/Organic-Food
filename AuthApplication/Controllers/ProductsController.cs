using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AuthApplication.Data;
using AuthApplication.Models;
using AuthApplication.ViewModels;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using cloudscribe.Pagination.Models;

namespace AuthApplication.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AuthDBContext _context;
        private readonly IWebHostEnvironment hostingEnvironment;

        public ProductsController(AuthDBContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            this.hostingEnvironment = hostingEnvironment;
        }

        // GET: Products
        public IActionResult Index(string  name, string  category,int PageNumber = 1, int PageSize = 4)
        {
            var result = new PagedResult<Product>();
            
            int ExcludeRecords = (PageSize * PageNumber) - PageSize;
            if(name !=null && category ==null)
            {
                var authApplicationContext = _context.products.Where(p => p.Name.Contains(name)).Include(p => p.Category)
                .Skip(ExcludeRecords)
                .Take(PageSize);
                 result = new PagedResult<Product>
                {
                    Data = authApplicationContext.AsNoTracking().ToList(),
                    TotalItems = _context.products.Count(),
                    PageNumber = PageNumber,
                    PageSize = PageSize
                };
                 
                return PartialView(result);
            }
            else if(category != null && name==null)
            {
                var authApplicationContext = _context.products.Where(p => p.Category.Name==category).Include(p => p.Category)
                .Skip(ExcludeRecords)
                .Take(PageSize);
                result = new PagedResult<Product>
                {
                    Data = authApplicationContext.AsNoTracking().ToList(),
                    TotalItems = _context.products.Count(),
                    PageNumber = PageNumber,
                    PageSize = PageSize
                };
                return View(result);
            }
            else
            {
                var authApplicationContext = _context.products.Include(p => p.Category)
                .Skip(ExcludeRecords)
                .Take(PageSize);
                result = new PagedResult<Product>
                {
                    Data = authApplicationContext.AsNoTracking().ToList(),
                    TotalItems = _context.products.Count(),
                    PageNumber = PageNumber,
                    PageSize = PageSize
                };
                return View(result);
            }
        }

        public IActionResult Index2(int PageNumber=1 , int PageSize=4)
        {
            int ExcludeRecords = (PageSize * PageNumber) - PageSize;
            var authApplicationContext = _context.products.Include(p => p.Category)
                .Skip(ExcludeRecords)
                .Take(PageSize);

            var result = new PagedResult<Product>
            {
                Data = authApplicationContext.AsNoTracking().ToList(),
                TotalItems = _context.products.Count(),
                PageNumber = PageNumber,
                PageSize = PageSize
            }; 
            return View(result);
        }
        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        public async Task<IActionResult> UserProductDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            

            var Comments= _context.Comments.Where(c => c.ProductID == id).Include(c => c.User).ToList() ;
            var product = await _context.products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ID == id);
            ViewBag.Product = product;
            ViewBag.Comments = Comments;
            if (product == null)
            {
                return NotFound();
            }

            return View();
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            ViewData["CategoryID"] = new SelectList(_context.categories, "ID", "Name");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,ImageSrc,Price,Description,CategoryID")] ProductCreateViewModel model)
        {
            Product newProduct = new Product();
            if (ModelState.IsValid)
            {
                string uniqueFileName = ProcessUploadedFile(model);
                 newProduct = new Product
                {
                    Name = model.Name,
                    Price = model.Price,
                    Description = model.Description,
                    Category = model.Category,
                    CategoryID = model.CategoryID,
                    Image = uniqueFileName
                };
                _context.Add(newProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index2));
            }
            ViewData["CategoryID"] = new SelectList(_context.categories, "ID", "Name", newProduct.CategoryID);
            return View(newProduct);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.products.FindAsync(id);

            ProductEditViewModel productEditViewModel = new ProductEditViewModel
            {
                ID = product.ID,
                Name = product.Name,
                Price = product.Price,
                Category = product.Category,
                CategoryID = product.CategoryID,
                Description = product.Description,
                ExistingPhotoPath = product.Image
                
        };
            if (product == null)
            {
                return NotFound();
            }
            ViewData["CategoryID"] = new SelectList(_context.categories, "ID", "Name", product.CategoryID);
            return View(productEditViewModel);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,ImageSrc,Price,Description,CategoryID")] ProductEditViewModel model)
        {
            Product product = new Product();
            if (ModelState.IsValid)
            {
                product = _context.products.Where(p => p.ID == model.ID).FirstOrDefault();

                product.Name = model.Name;
                product.Price = model.Price;
                product.Description = model.Description;
                product.CategoryID = model.CategoryID;
                product.Category = model.Category;

                if(model.ImageSrc != null)
                {
                    if (model.ExistingPhotoPath != null)
                    {
                        string filePath = Path.Combine(hostingEnvironment.WebRootPath, 
                                            "images", model.ExistingPhotoPath);
                        System.IO.File.Delete(filePath);
                    }
                    product.Image = ProcessUploadedFile(model);
                }
                
                _context.Update(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index2));
            }
            
            return View();
        }

        //yo get and store the path of the image with a unique name
        private string ProcessUploadedFile(ProductCreateViewModel model)
        {
            string uniqueFileName = null;
            if (model.ImageSrc != null)
            {
                string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ImageSrc.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                //to avoid when two product use the same image
                using(var fileStream= new FileStream(filePath, FileMode.Create))
                {
                    model.ImageSrc.CopyTo(fileStream);
                }
                
            }

            return uniqueFileName;
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.products.FindAsync(id);
            _context.products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index2));
        }

        private bool ProductExists(int id)
        {
            return _context.products.Any(e => e.ID == id);
        }
    }
}
