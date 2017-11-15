using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxManager.Models;
using FoxManager.Repositories;
using FoxManager.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoxManager.Controllers
{
    [Route("/home")]
    public class HomeController : Controller
    {
        private FoxManagerService FoxManagerService;

        public HomeController(FoxManagerService foxManagerService)
        {
            FoxManagerService = foxManagerService;
        }

        [HttpPost]
        public IActionResult LoginHandler(Student studentFromForm)
        {
            if (FoxManagerService.AuthenticateStudent(studentFromForm.Name))
            {
                return LocalRedirect("/student/" + studentFromForm.Name);
            }

            return LocalRedirect("/");
        }

        [HttpGet]
        [Route("/student/{studentName}")]
        public IActionResult Profile(string studentName)
        {
            var user = FoxManagerService.GetStudentInfo(studentName);
            var projects = FoxManagerService.GetStudentProjects(studentName);
            return View(user);
        }
    }
}
