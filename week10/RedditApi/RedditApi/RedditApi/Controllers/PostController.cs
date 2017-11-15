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

        [HttpPost]
        [Route("/posts")]
        public IActionResult AddNewPost([FromBody]Post post)
        {
            PostRepository.AddNewPost(post);
            return Json(post);
        }

        [HttpPut]
        [Route("posts/{id}/upvote")]
        public IActionResult UpVote(int id)
        {
            PostRepository.UpVote(id);
            return Json(PostRepository.GetPostById(id));
        }

        [HttpPut]
        [Route("posts/{id}/downvote")]
        public IActionResult DownVote(int id)
        {
            PostRepository.DownVote(id);
            return Json(PostRepository.GetPostById(id));
        }

        [HttpPut]
        [Route("posts/{id}")]
        public IActionResult UpdateTitle(int id, [FromBody]Post post)
        {
            PostRepository.UpdateTitle(id, post);
            return Json(post);
        }
    }
}
