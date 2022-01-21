using EF_Intro.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Intro.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=10.7.101.197;Database=EF09;USer Id=test;Password=1;MultipleActiveResultSets=True;");
            }
        }

        public DbSet<User> Users { get; set; }
        //public DbSet<Countries> Countries { get; set; }
    }
}
