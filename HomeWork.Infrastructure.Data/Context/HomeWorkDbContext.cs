using HomeWork.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Infrastructure.Data.Context
{
    public class HomeWorkDbContext : DbContext
    {
        public HomeWorkDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Food> Foods { get; set; }
        public DbSet<Restaurant> Restaurant{ get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

