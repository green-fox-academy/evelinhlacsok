using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RedditApi.Entities;
using RedditApi.Models;

namespace RedditApi.Repositories
{
    public class PostRepository
    {
        PostContext PostContext;

        public PostRepository(PostContext postContext)
        {
            PostContext = postContext;
        }

        public List<Post> ListPosts()
        {
            return PostContext.Reddit.ToList();
        }

    }
}
