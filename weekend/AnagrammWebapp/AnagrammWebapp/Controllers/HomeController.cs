using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnagrammWebapp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnagrammWebapp.Controllers
{
    public class HomeController : Controller
    {
        AnagrammCheck anagrammcheck;

        public HomeController(AnagrammCheck anagrammcheck)
        {
            this.anagrammcheck = anagrammcheck;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [Route("isAnagramm")]
        public IActionResult isAnagramm(string firstword, string secondword)
        {
            anagrammcheck.FirstWord = firstword;
            anagrammcheck.SecondWord = secondword;

            return RedirectToAction("Result");
        }

        [HttpGet]
        [Route("isAnagramm")]
        public IActionResult Result()
        {
            return View(anagrammcheck);
        }
    }
}