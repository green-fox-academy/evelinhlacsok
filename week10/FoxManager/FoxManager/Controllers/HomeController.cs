using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxManager.Models;
using FoxManager.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoxManager.Controllers
{
    [Route("/home")]
    public class HomeController : Controller
    {
        private FoxManagerRepository FoxManagerRepository;

        public HomeController(FoxManagerRepository foxManagerRepository)
        {
            FoxManagerRepository = foxManagerRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var list = FoxManagerRepository.GetStudentList();
            return View(FoxManagerRepository.GetStudentList());
        }
    }
}
