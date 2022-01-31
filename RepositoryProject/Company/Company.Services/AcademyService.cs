using Company.Data.Data.Interfaces;
using Company.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Services
{
    public class AcademyService
    {
        private readonly IAcademyRepository _academyRepository;
        public AcademyService(IAcademyRepository academyRepository)
        {
            _academyRepository = academyRepository;
        }

        public List<Course> GetAllCourses()
        {
            var result = _academyRepository.GetAllCourses();
            return result;
        }
    }
}
