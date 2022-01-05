using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EADCW2.Server.Models
{
    public class Ticket
    {
        public int ticketId { get; set; }
        public string taskTitle { get; set; }
        public string taskDescription { get; set; }
        public DateTime taskCreateDate { get; set; }
        public int projectId { get; set; }

        public Project project { get; set; }

    }
}
