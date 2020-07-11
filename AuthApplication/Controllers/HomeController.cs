using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AuthApplication.Models;
using Microsoft.AspNetCore.Authorization;
using AuthApplication.Data;
using Microsoft.EntityFrameworkCore;
using cloudscribe.Pagination.Models;

namespace AuthApplication.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly AuthDBContext _context;
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, AuthDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index(int PageNumber = 1, int PageSize = 4)
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
            ViewBag.layout = "~/Views/Shared/_Layout.cshtml";
            if (User.IsInRole("Admin"))
            {
                // return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
                ViewBag.layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
            }
            
                return View(result);
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
