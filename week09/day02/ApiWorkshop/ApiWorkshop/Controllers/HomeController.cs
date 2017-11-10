using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiWorkshop.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiWorkshop.Models
{
    [Route("")]
    public class HomeController : Controller
    {

        [HttpGet]
		[Route("")]
        public IActionResult Index()
        {
            return File("Index.html", "text/html");
        }

        [HttpGet]
        [Route("doubling")]
        public IActionResult Doubling(int? input)
        {
            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            return Json(new { received = input, result = input * 2 });
        }

        [HttpGet]
        [Route("greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if (name == null)
            {
                return Json(new { error = "Please provide a name!" });
            }
            else if (title == null)
            {
                return Json(new { error = "Please provide a title!" });
            }
            else
            return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
        }

        [HttpGet]
        [Route("appenda/{appendable}")]
        public IActionResult AppendA(string appendable)
        {
            return Json(new { appended = $"{appendable}a" });
        }

        [HttpGet]
        [Route("/appenda/")]
        public IActionResult Append()
        {
            return NotFound();
        }

        [HttpPost]
        [Route("dountil/{what}")]
        [Route("dountil/")]
        public IActionResult DoUntil([FromBody] JsonObject jsonObject, string what)
        {
            if (what == "factor")
            {
                int factorial = 1;
                for (int i = 1; i < jsonObject.Until + 1; i++)
                {
                    factorial *= i;
                }
                return Json(new { result = factorial });
            }
            else if (what == "sum")
            {
                int sum = 0;
                for (int i = 1; i < jsonObject.Until + 1; i++)
                {
                    sum += i;
                }
                return Json(new { result = sum });
            }
                return Json(new { error = "Please provide a number!" });
        }

        [HttpPost]
        [Route("array")]
        public IActionResult ArrayHandler([FromBody] Pownie pownie)
        {
            if (pownie.Action == "Sum")
            {
                int result = pownie.Sum(pownie.Number);
                return Json(new { result = result });
            }

            if (pownie.Action == "Multiply")
            {
                int result = pownie.Multiply(pownie.Number);
                return Json(new { result = result });
            }

            if (pownie.Action == "Double")
            {
                int[] result = pownie.Double(pownie.Number);
                return Json(new { result = result });
            }
            return Json(new { error = "Please provide what to do with the numbers!" });
        }
    }
}