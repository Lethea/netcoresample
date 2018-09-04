using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tuts.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("app/contact")]
        public IActionResult Contact()
        {
            
            ViewBag.Title = "Contact";
            return View();
        }
        [HttpPost("app/contact")]
        public IActionResult Contact(object model)
        {
            return View();
        }
    }
}