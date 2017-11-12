using System;
using Microsoft.EntityFrameworkCore;
using Reddit.Models;

namespace Reddit.Entities
{
    public class ContentContext : DbContext
    {
        public ContentContext(DbContextOptions<ContentContext> options) : base(options)
        {
        }

        public DbSet<Content> Contents { get; set; }
    }
}
