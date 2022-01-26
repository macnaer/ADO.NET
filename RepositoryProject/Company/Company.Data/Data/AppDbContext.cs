using Company.Data.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=194.44.93.225;Database=EFRepository;User Id=test;Password=1;MultipleActiveResultSets=True;");
            }
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ITCompany>().Property(c => c.Name).IsRequired().HasMaxLength(60).HasColumnType("varchar(60)");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<ITCompany> ITCompanies { get; set; }

    }
}
