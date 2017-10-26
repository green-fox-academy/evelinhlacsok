using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DependencyInjectionWorkshop.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DependencyInjectionWorkshop.Controllers
{
    public class HomeController : Controller
    {
        Counter counter;

        public HomeController(Counter counter)
        {
            this.counter = counter;
        }

        [HttpGet]
        [Route("index")]
        public IActionResult Index()
        {
            return View(counter);
        }

        [HttpPost]
        [Route("index")]
        public IActionResult Count()
        {
            counter.Raise();
            return RedirectToAction("Index");
        }
    }
}
