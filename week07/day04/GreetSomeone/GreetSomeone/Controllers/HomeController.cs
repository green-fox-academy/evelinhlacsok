using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GreetSomeone.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GreetSomeone.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("index")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        [Route("index")]
        public IActionResult Greet()
        {
            return View();
        }
    }
}