using Company.Data.Data.Interfaces;
using Company.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Services
{
    public class ITCompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public ITCompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public void AddCompany(ITCompany company)
        {
            _companyRepository.AddCompany(company);
        }
    }
}
