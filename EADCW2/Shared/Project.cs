using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EADCW2.Shared
{
    public class Project
    {
        public int projectId { get; set; }
        [Required]
        [StringLength(500, ErrorMessage = "The title is too long, try a shorter one (500 character limit) ")]
        public string projectName { get; set; }
        [Required]
        [StringLength(8000, ErrorMessage = "The description is too long, try a shorter one (8000 character limit) ")]
        public string projectDescription { get; set; }  
        public int companyProjectId { get; set; }

        public Company companyProject { get; set; }

        public ICollection<Developer> developers { get; set; }
        public ICollection<Ticket> companyTask { get; set; }

    }
}
