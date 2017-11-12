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

        [Route("/add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [Route("/add")]
        [HttpPost]
        public IActionResult Add(string content)
        {
            ContentRepository.AddPost(content);
            return RedirectToAction("index");
        }

        [Route("/{id}/delete")]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            ContentRepository.DeletePost(id);
            return RedirectToAction("index");
        }
    }
}
