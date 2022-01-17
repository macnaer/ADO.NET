using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_to_SQL_Intro
{
    class Program
    {
        static void Main(string[] args)
        {

            //=====================1======================//
            /*using (UsersDataContext context = new UsersDataContext())
            {
                var users = context.Users.Where(u => u.UsersID == 5);
                foreach(var user in users)
                {
                    Console.WriteLine("Id: {0} | Name: {1} | Surname: {2} | Email : {3} | Phone: {4} | Age: {5}", user.UsersID, user.Name, user.Surname, user.Email, user.Phone, user.Age);
                }
            }*/
            //=====================1======================//
            //=====================2======================//
            /*using (UsersDataContext context = new UsersDataContext())
            {
                var users = from User in context.Users orderby User.Surname descending select User;
                foreach (var user in users)
                {
                    Console.WriteLine("Id: {0} | Name: {1} | Surname: {2} | Email : {3} | Phone: {4} | Age: {5}", user.UsersID, user.Name, user.Surname, user.Email, user.Phone, user.Age);
                    Console.WriteLine(new string('=', 120));
                }
            }*/
            //=====================2======================//
            //=====================3======================//
            /*using (UsersDataContext context = new UsersDataContext())
            {
                User newUser = new User()
                {
                    Name = "Robert",
                    Surname = "Borateon",
                    Email = "rb@email.com",
                    Phone = "096-784-45-12",
                    Age = 93
                };

                context.Users.InsertOnSubmit(newUser);
                context.SubmitChanges();

                var users = context.Users.Where(u => u.Email == "rb@email.com");
                foreach (var user in users)
                {
                    Console.WriteLine("Id: {0} | Name: {1} | Surname: {2} | Email : {3} | Phone: {4} | Age: {5}", user.UsersID, user.Name, user.Surname, user.Email, user.Phone, user.Age);
                }
            }*/
            //=====================3======================//
            //=====================4======================//
            /*using (UsersDataContext context = new UsersDataContext())
            {
                User user = context.Users.SingleOrDefault(u => u.UsersID == 506);
                user.Age = 94;
                context.SubmitChanges();

                Console.WriteLine("Id: {0} | Name: {1} | Surname: {2} | Email : {3} | Phone: {4} | Age: {5}", user.UsersID, user.Name, user.Surname, user.Email, user.Phone, user.Age);
            }*/
            //=====================4======================//
            //=====================5======================//
            /*using (UsersDataContext context = new UsersDataContext())
            {
                User user = context.Users.SingleOrDefault(u => u.UsersID == 507);
                context.Users.DeleteOnSubmit(user);
                context.SubmitChanges();
            }*/
            //=====================5======================//
        }
    }
}
