using EADCW2.Server.Models;
using EADCW2.Server.Data;
using System.Collections.Generic;
using System.Linq;

namespace EADCW2.Server.Controllers
{
    
    public class CompanyController : ICompanyService
    {
        private readonly ApplicationDbContext _db;

        public CompanyController(ApplicationDbContext db)
        {
            _db = db;    
        }

        public bool create(Company company)
        {
            if (company != null)
            {
               _db.Companies.Add(company);
               _db.SaveChanges();
                return true;
            }

            return false;
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Company Get(int id)
        {
            return _db.Companies.Find(id);
        }

        public List<Company> listOfCompanies()
        {
            return _db.Companies.ToList();
        }

        public Company Upate(Company company)
        {
            var dbCompany = _db.Companies.Find(company.Id);
            if(dbCompany != null)
            {
                dbCompany = company;
                _db.SaveChanges();  
                
            }

            return dbCompany;
        }
    }
}
