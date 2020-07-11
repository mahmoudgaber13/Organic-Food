using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using AuthApplication.Areas.Identity.Data;
using AuthApplication.Data;
using AuthApplication.Extensions;
using AuthApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Core;

namespace AuthApplication.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly AuthDBContext _context;
        private readonly IHttpContextAccessor HttpContextAccessor;

        private string strCart = "Cart";

        public ShoppingCartController(AuthDBContext context,IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            HttpContextAccessor = httpContextAccessor;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OrderNow(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            if (string.IsNullOrEmpty(HttpContext.Session.GetString(strCart))
)
            {
                List<Cart> lsCart = new List<Cart>
                {
                    new Cart(1,_context.products.Find(id))
                };
                HttpContext.Session.Set<List<Cart>>(strCart, lsCart);
            }
            else
            {
                List<Cart> lsCart = (List<Cart>)HttpContext.Session.Get<List<Cart>>(strCart);
                int check = IsExistingcheck(id);
                if (check == -1)
                    lsCart.Add(new Cart(1, _context.products.Find(id)));
                else
                    lsCart[check].Quantity++;
                HttpContext.Session.Set<List<Cart>>(strCart, lsCart);
            }
            return RedirectToAction("Index", "Home");
        }
        private int IsExistingcheck(int? id)
        {
            List<Cart> lsCart = HttpContext.Session.Get<List<Cart>>(strCart);
            for (int i = 0; i < lsCart.Count; i++)
            {
                if (lsCart[i].Product.ID == id) return i;
            }
            return -1;
        }

        //--------------------------------Delete
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            int check = IsExistingcheck(id);
            List<Cart> lsCart = (List<Cart>)HttpContext.Session.Get<List<Cart>>(strCart);
            
            var cart = lsCart[check];
            lsCart.RemoveAt(check);
            cart.Quantity = cart.Quantity-1;
            
            lsCart.Add(cart);
            if(cart.Quantity == 0)
                lsCart.Remove(cart);
            HttpContext.Session.Set<List<Cart>>(strCart, lsCart);
            return View("Index");
        }

        //---------------------------------Make Order
        public IActionResult MakeOrder(string name)
        {
            var UserId = HttpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ApplicationUser user = _context.Users.Find(UserId);
            List<Cart> lsCart = HttpContext.Session.Get<List<Cart>>(strCart);
            List<Product> products = new List<Product>();
            
            int Q = 0;
            foreach (Cart cart in lsCart)
            {
                Product prd = new Product();
                prd.Name = cart.Product.Name;
                prd.Image = cart.Product.Image;
                prd.Price = cart.Product.Price;
                prd.Description = cart.Product.Description;
                prd.Category = cart.Product.Category;
                products.Add(prd);
                Q = cart.Quantity;
            }
            Order order = new Order
            {
                //Products=products,
                UserID = user.Id,
                Address = user.Country + " : " + user.City,
                Email = user.Email,
                Date = System.DateTime.Now,
                Status = "Pendding",
                Quantity = Q,
                

            };
            

            _context.orders.Add(order);
            _context.SaveChanges();
            foreach (Cart cart in lsCart)
            {
                OrderDetails orderDetailes = new OrderDetails
                {
                    OrderId = order.ID,
                    Quantity = cart.Quantity,
                    Price = (int)cart.Product.Price,
                    Products= products

                };
                _context.OrderDetails.Add(orderDetailes);
                _context.SaveChanges();
            }
            HttpContext.Session.Clear();
            return View("MakeOrder");
        }

    }
}
