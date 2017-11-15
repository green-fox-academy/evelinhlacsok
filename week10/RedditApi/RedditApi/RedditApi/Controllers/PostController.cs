using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedditApi.Models;
using RedditApi.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RedditApi.Controllers
{
    public class PostController : Controller
    {
        PostRepository PostRepository;

        public PostController(PostRepository postRepository)
        {
            PostRepository = postRepository;
        }

        [HttpGet]
        [Route("/posts")]
        public IEnumerable<Post> ListPosts()
        {
            return PostRepository.ListPosts();
        }


    }
}
