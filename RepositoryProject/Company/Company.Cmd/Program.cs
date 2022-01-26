using Company.Data.Data.Classes;
using Company.Data.Data.Models;
using Company.Services;
using System;

namespace Company.Cmd
{
    class Program
    {
       

        static void Main(string[] args)
        {
            ITCompanyService _companyService = new ITCompanyService(new CompanyRepository());

            Console.WriteLine("Company name: ");
            var name = Console.ReadLine();
            ITCompany iTCompany = new ITCompany()
            {
                Name = name
            };

            _companyService.AddCompany(iTCompany);
        }
    }
}
