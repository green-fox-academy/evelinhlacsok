using System;
using Microsoft.EntityFrameworkCore;
using RedditApi.Models;

namespace RedditApi.Entities
{
    public class PostContext : DbContext
    {
        public PostContext(DbContextOptions<PostContext> options) : base(options)
        {
        }

        public DbSet<Post> Reddit { get; set; }
    }
}
