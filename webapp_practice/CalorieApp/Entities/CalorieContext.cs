using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CalorieApp.Entities
{
    public class CalorieContext : DbContext
    {
        public CalorieContext(DbContextOptions<CalorieContext> options) : base(options)
        {
        }

		public DbSet<Food> Foods { get; set; }
    }
}
