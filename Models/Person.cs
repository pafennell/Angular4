using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Angular4.Models
{
    public class Person
    {
        public int PersonID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string Town { get; set; }

        public string state { get; set; }

        public string MobilPhone { get; set; }
        [Required]
        public string Phone { get; set; }
    }
}
