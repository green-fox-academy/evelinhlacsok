using System;
using RedditApi.Entities;

namespace RedditApi.Repositories
{
    public class PostRepository
    {
        PostContext PostContext;

        public PostRepository (PostContext postContext)
        {
            PostContext = postContext;
        }

    }
}
