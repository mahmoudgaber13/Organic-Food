using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AuthApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CalenderController : Controller
    {
        [Route("admin/Callender")]
        public IActionResult Index()
        {
            return View();
        }
    }
}