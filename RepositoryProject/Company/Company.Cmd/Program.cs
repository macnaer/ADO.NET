using Company.Data.Data.Classes;
using Company.Data.Data.Models;
using Company.Services;
using System;
using System.Linq;

namespace Company.Cmd
{
    class Program
    {
       

        static void Main(string[] args)
        {
            ITCompanyService _companyService = new ITCompanyService(new CompanyRepository());
            AcademyService _academyService = new AcademyService(new AcademyRepository());

            //Console.WriteLine("Company name: ");
            //var name = Console.ReadLine();
            //ITCompany iTCompany = new ITCompany()
            //{
            //    Name = name
            //};

            //_companyService.AddCompany(iTCompany);

            var courses = _academyService.GetAllCourses();
            foreach(var course in courses)
            {
                Console.WriteLine($"Course: {course.Name}");
                var students = course.StudentCourses.Select(sc => sc.Student).ToList();
                foreach(var student in students)
                {
                    Console.WriteLine($"Student name: {student.Name}");
                }
                Console.WriteLine(new string('_', 40));
            }
        }
    }
}
