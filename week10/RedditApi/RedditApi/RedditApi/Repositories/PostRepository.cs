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

        public void AddNewPost(Post post)
        {
            PostContext.Reddit.Add(post);
            PostContext.SaveChanges();
        }

        public Post GetPostById(int id)
        {
            var selectedPost = PostContext.Reddit.FirstOrDefault(post => post.Id == id);
            return selectedPost;
        }

        public void UpVote(int id)
        {
            var post = GetPostById(id);

            post.Score++;

            PostContext.Reddit.Update(post);
            PostContext.SaveChanges();
        }

        public void DownVote(int id)
        {
            var post = GetPostById(id);

            post.Score--;

            PostContext.Reddit.Update(post);
            PostContext.SaveChanges();
        }
    }
}
