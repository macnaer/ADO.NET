using EF_Data_Annotation.Data.Models;
using EF_Data_Annotation.Data.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EF_Data_Annotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Surname");
            string surname = Console.ReadLine();

            Console.WriteLine("Phone");
            string phone = Console.ReadLine();

            Console.WriteLine("Age");
            int age = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Password");
            string password = Console.ReadLine();

            Console.WriteLine("Confirm password");
            string confirmPassword = Console.ReadLine();

            User user = new User()
            {
                Name = name,
                Surname = surname,
                Phone = phone,
                Age = age,
                Password = password,
                ConfirmPassword = confirmPassword
            };

            var results = new List<ValidationResult>();
            var context= new ValidationContext(user);

            if (!Validator.TryValidateObject(user, context, results, true))
            {
                foreach(var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
            else
            {
                try
                {
                    UserRepository.AddUser(user);
                    Console.WriteLine("User successfully created");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error ", ex.Message);
                }
            }
        }
    }
}
