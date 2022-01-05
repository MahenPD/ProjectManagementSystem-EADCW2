using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EADCW2.Server.Models
{
    public class Company
    {
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }

        public ICollection<Developer> companyBasedDevelopers { get; set; }
        public ICollection<Project> companyBasedProjects { get; set; }
    }
}
