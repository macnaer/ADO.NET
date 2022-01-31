using Company.Data.Data.Interfaces;
using Company.Data.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Data.Classes
{
    public class AcademyRepository : IAcademyRepository
    {
        public List<Course> GetAllCourses()
        {
            using (AppDbContext context = new AppDbContext()) 
            {
                var courses = context.Course.Include(c => c.StudentCourses).ThenInclude(sc => sc.Student).ToList();
                return courses;
            }
        }
    }
}
