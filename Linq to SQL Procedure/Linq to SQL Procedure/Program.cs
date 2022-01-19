using Linq_to_SQL_Procedure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_to_SQL_Procedure
{
    class Program
    {
        static void Main(string[] args)
        {
            //========================1=========================//
            /*using (UsersDataContext context = new UsersDataContext())
            {
                var users = context.GetUsers();
                foreach(var user in users)
                {
                    Console.WriteLine($"Id: {user.UsersID}\nName: {user.Name}\nSurname: {user.Surname}\nEmail: {user.Email}\nPhome: {user.Phone}\nAge: {user.Age}");
                    Console.WriteLine(new string('_', 50));
                }
            }*/
            //========================1=========================//
            //========================2=========================//
            /*using (UsersDataContext context = new UsersDataContext())
            {
                try
                {
                    context.InsertUser("Ronald", "MacDonald", "(097)-458-78-32", "macdonald@email.com", 34);
                    Console.WriteLine($"User successfully added");
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"Error, {ex.Message}");
                }
            }*/
            //========================2=========================//
            //========================3=========================//
            /*using (UsersDataContext context = new UsersDataContext())
            {
                try
                {
                    context.UpdateUser(1512,"Ronald", "MacDonald", "(097)-458-78-55", "macdonald@email.com", 35);
                    Console.WriteLine($"User successfully updated");
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"Error, {ex.Message}");
                }
            }*/
            //========================3=========================//
            //========================4=========================//
            using (UsersDataContext context = new UsersDataContext())
            {
                try
                {
                    context.DeleteUser(1512);
                    Console.WriteLine($"User successfully deleted");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error {ex.Message}");
                }
            }
            //========================4=========================//
        }
    }
}
