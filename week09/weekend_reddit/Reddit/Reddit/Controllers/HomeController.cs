using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reddit.Repositories;
using Reddit.Models;

namespace Reddit.Controllers
{
    public class HomeController : Controller
    {
        private ContentRepository ContentRepository;

        public HomeController(ContentRepository contentRepository)
        {
            ContentRepository = contentRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
