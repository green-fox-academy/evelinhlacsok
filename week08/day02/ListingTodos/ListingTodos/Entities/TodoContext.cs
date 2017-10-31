using System;
using ListingTodos.Models;
using Microsoft.EntityFrameworkCore;

namespace ListingTodos.Entities
{
    public class TodoContext : DbContext
    {
       /* public TodoContext(DbContextOptions<TodoContext> options):base(options)
        {
        }*/

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=blogging.db");
        }

        DbSet<Todo> Todos { get; set; }
    }
}
