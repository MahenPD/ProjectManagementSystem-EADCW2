using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EADCW2.Shared
{
    public class User
    {
        public int userId { get; set; }
        [Required]
        public string userName { get; set; }
        [Required]
        public string userEmail { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "The contact number needs to be 10 characters")]
        public string userContactNo { get; set; }

        public string DiscriminatorValue
        {
            get
            {
                return this.GetType().Name;
            }
        }
    }
}
