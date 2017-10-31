﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ListingTodos.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ListingTodos.Controllers
{
	[Route("todo")]
    public class TodoController : Controller
    {
        [Route("")]
		[Route("list")]
        public IActionResult List()
        {
            return View();
        }  
    }
}