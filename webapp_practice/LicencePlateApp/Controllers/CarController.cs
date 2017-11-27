using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LicencePlateApp.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LicencePlateApp.Controllers
{
    [Route("")]
    public class CarController : Controller
    {
        CarRepository CarRepository;

        public CarController(CarRepository carRepository)
        {
            CarRepository = carRepository;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View(CarRepository.GetAllCars());
        }

        [HttpGet]
        [Route("/search")]
        public IActionResult SearchResult(string plate)
        {
            return View("Index", CarRepository.GetResultFromDb(plate));
        }

        [HttpGet]
        [Route("/search/police")]
        public IActionResult PoliceCars()
        {
            return View("Index", CarRepository.PoliceCars());
        }

        [HttpGet]
        [Route("search/diplomat")]
        public IActionResult DiplomatCars()
        {
            return View("Index", CarRepository.DiplomatCars());
        }
    }
}
