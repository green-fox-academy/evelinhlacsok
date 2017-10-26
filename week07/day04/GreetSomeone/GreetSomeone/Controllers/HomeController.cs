﻿using System;
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
        Greet greet;

        public HomeController(Greet greet)
        {
            this.greet = greet;
        }

        [HttpGet]
        [Route("submit")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("submit")]
        public IActionResult Greet(string name)
        {
            greet.Name = name;
            return RedirectToAction("Greet");
        }

        [HttpGet]
        [Route("greet")]
        public IActionResult ShowData()
        {
            return View(greet);
        }
    }
}