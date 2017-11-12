using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reddit.Repositories;
using Reddit.Models;

namespace Reddit.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private ContentRepository ContentRepository;

        public HomeController(ContentRepository contentRepository)
        {
            ContentRepository = contentRepository;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View(ContentRepository.GetList());
        }
    }
}
