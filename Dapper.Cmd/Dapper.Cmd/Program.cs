using Dappaer.Services;
using Dapper.Data.Data.Classes;
using Dapper.Data.Data.Models;

class Program
{
    static void Main(string[] args)
    {
        UserService _userService = new UserService(new UserRepository());

        //Console.WriteLine("Username");
        //string name = Console.ReadLine();
        //Console.WriteLine("Age");
        //int age = int.Parse(Console.ReadLine());

        //User user = new User()
        //{
        //    Name = name,
        //    Age = age,
        //};

        //_userService.Create(user);

        //var users = _userService.GetAll();
        //foreach (var user in users)
        //{
        //    Console.WriteLine($"Name: {user.Name}\nAge: {user.Age}\n_________________");
        //}

        Console.WriteLine("Enter user id");
        int id = int.Parse(Console.ReadLine());
        var user = _userService.Get(id);
        Console.WriteLine($"Name: {user.Name}\nAge: {user.Age}\n_________________");


        //Console.WriteLine("Enter user id for delete");
        //int id = int.Parse(Console.ReadLine());

        //_userService.Delete(id);


        //Console.WriteLine("Id");
        //int id = int.Parse(Console.ReadLine());
        //Console.WriteLine("Username");
        //string name = Console.ReadLine();
        //Console.WriteLine("Age");
        //int age = int.Parse(Console.ReadLine());

        //User user = new User()
        //{
        //    Id = id,
        //    Name = name,
        //    Age = age,
        //};

        //_userService.Update(user);

    }
}