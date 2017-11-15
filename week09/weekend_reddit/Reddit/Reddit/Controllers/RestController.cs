using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reddit.Models;
using Reddit.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Reddit.Controllers
{
    [Route("api")]
    public class RestController : Controller
    {
        private ContentRepository ContentRepository;

        public RestController(ContentRepository contentRepository)
        {
            ContentRepository = contentRepository;
        }

        [HttpGet]
        [Route("/posts")]
        public IEnumerable<Content> ListPosts()
        {
            return ContentRepository.GetList();
        }

    }
}
