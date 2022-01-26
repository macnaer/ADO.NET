using Company.Data.Data.Models;
using Company.Services;
using System;

namespace Company.Cmd
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Company name: ");
            var name = Console.ReadLine();
            ITCompany iTCompany = new ITCompany()
            {
                Name = name
            };


        }
    }
}
