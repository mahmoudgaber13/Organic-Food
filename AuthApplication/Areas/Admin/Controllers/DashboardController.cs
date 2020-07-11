using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AuthApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/Dashboard")]
    public class DashboardController : Controller
    {
       
        [Route("index")]
        [Route("")]

        public IActionResult Index()
        {
            return View();
        }
    }
}