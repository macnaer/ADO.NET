using Company.Data.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Data.Initializer
{
    public static class DbInitializer
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ITCompany>().HasData(
                    new ITCompany
                    {
                        Id = 1,
                        Name = "Microsoft"
                    }
                );
            modelBuilder.Entity<User>().HasData(
                    new User
                    {
                        Id = 1,
                        Name = "Bill",
                        Surname = "Gates",
                        Position = "CEO",
                        Salary = 30000,
                        CompanyId = 1
                    },
                    new User
                    {
                        Id = 2,
                        Name = "Stiven",
                        Surname = "Woznyak",
                        Position = "CEO",
                        Salary = 20000,
                        CompanyId = 1
                    }
                );
            modelBuilder.Entity<Student>().HasData(
                    new Student
                    {
                        Id = 1,
                        Name = "Stiven Anderson",
                    },
                    new Student
                    {
                        Id = 2,
                        Name = "Jack Sallivan",
                    },
                     new Student
                     {
                          Id = 3,
                          Name = "Emma Sallivan",
                     }
                );

            modelBuilder.Entity<Course>().HasData(
                   new Course
                   {
                       Id = 1,
                       Name = "C++",
                   },
                   new Course
                   {
                       Id = 2,
                       Name = "Networking"
                   }
               );
            modelBuilder.Entity<StudentCourse>().HasData(
                    new StudentCourse
                    {
                        Id = 1,
                        StudentId = 1,
                        CourseId = 1
                    },
                    new StudentCourse
                    {
                         Id = 2,
                         StudentId = 2,
                         CourseId = 2
                    },
                    new StudentCourse
                    {
                        Id = 3,
                        StudentId = 3,
                        CourseId = 2
                    }
                );
        }
    }
}
