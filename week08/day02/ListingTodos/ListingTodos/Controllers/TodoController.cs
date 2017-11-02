using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ListingTodos.Models;
using ListingTodos.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ListingTodos.Controllers
{
	//[Route("todo")]
    public class TodoController : Controller
    {
        private TodoRepository TodoRepository;

        public TodoController(TodoRepository todoRepository)
        {
            TodoRepository = todoRepository;
        }

        [Route("")]
		[Route("list")]
        public IActionResult List()
        {
            return View(TodoRepository.ListTasks());
        }  
        [Route("/add")]
		[HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [Route("/add")]
		[HttpPost]
        public IActionResult Add(string Title)
        {
            TodoRepository.AddTask(Title);
            return RedirectToAction("list");
        }
    }
}
