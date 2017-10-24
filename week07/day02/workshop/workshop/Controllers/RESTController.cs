using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using workshop.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace workshop.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        public static int counter = 0;
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [Route("greeting/{name}")]
        public IActionResult Greeting(string name)
        {
            counter++;
            return new JsonResult(new Greeting(counter, "hello " + name));
        }
    }
}
