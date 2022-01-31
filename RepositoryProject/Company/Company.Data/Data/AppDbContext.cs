using Company.Data.Data.Initializer;
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
                optionsBuilder.UseSqlServer(@"Server=194.44.93.225;Database=EFRepository;User Id=test;Password=Qwerty-1;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ITCompany>().Property(c => c.Name).IsRequired().HasMaxLength(60).HasColumnType("varchar(60)");

            modelBuilder.Entity<User>()
                .HasOne(u => u.Company)
                .WithMany(c => c.Users)
                .HasForeignKey(u => u.CompanyId);

            modelBuilder.Entity<StudentCourse>()
                .HasKey(t => new { t.StudentId, t.CourseId });

            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.StudentId);

            modelBuilder.Entity<StudentCourse>()
               .HasOne(sc => sc.Course)
               .WithMany(s => s.StudentCourses)
               .HasForeignKey(sc => sc.CourseId);



            modelBuilder.Seed();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<ITCompany> ITCompanies { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Student> Student { get; set; }

    }
}
