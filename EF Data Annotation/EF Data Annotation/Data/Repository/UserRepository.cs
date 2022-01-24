using EF_Data_Annotation.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Data_Annotation.Data.Repository
{
    public static class UserRepository
    {
        public static void AddUser(User user)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    }
}
