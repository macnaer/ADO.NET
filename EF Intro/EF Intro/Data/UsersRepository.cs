using EF_Intro.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Intro.Data
{
    public class UsersRepository
    {
        public static void Print()
        {
            using (AppDbContext context = new AppDbContext())
            {
                var users = context.Users.ToList();
                foreach (User user in users)
                {
                    Console.WriteLine($"Name: {user.Name}\nSurname: {user.Surname}\nEmail: {user.Email}\nAge: {user.Age}");
                    Console.WriteLine(new string('_', 30));
                }
            }
        }

        public static void AddUser(string name, string surname, string email, short age)
        {
            using (AppDbContext context = new AppDbContext())
            {
                User userBob = new User
                {
                    Name = name,
                    Surname = surname,
                    Email = email,
                    Age = age
                };
                context.Users.Add(userBob);
                context.SaveChanges();
            }
        }

        public static void UpdateUser(int id, string email, short age)
        {
            using (AppDbContext context = new AppDbContext())
            {
                User user = context.Users.Where(u => u.Id == id).FirstOrDefault();
                if(user != null)
                {
                    user.Email = email;
                    user.Age = age;
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine($"User with id {id} not found.");
                }         
            }
        }

        public static void DeleteUser(int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                User user = context.Users.Where(u => u.Id == id).FirstOrDefault();
                if (user != null)
                {
                    context.Users.Remove(user);
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine($"User with id {id} not found.");
                }
            }
        }
    }
}
