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
        }
    }
}
