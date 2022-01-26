using Company.Data.Data.Interfaces;
using Company.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Data.Classes
{
    public class CompanyRepository : ICompanyRepository
    {
        public void AddCompany(ITCompany company)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.ITCompanies.Add(company);
                context.SaveChanges();
            }
        }
    }
}
