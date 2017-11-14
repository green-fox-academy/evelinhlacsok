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
    [Route("")]
    public class HomeController : Controller
    {
        private FoxManagerRepository FoxManagerRepository;

        public HomeController(FoxManagerRepository foxManagerRepository)
        {
            FoxManagerRepository = foxManagerRepository;
        }

        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
