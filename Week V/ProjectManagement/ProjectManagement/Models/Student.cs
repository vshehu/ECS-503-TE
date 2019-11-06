using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Models
{
    public class Student : MyEntity
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(15)]
        [MinLength(2)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(15)]
        [MinLength(2)]
        public string LastName { get; set; }

        public DateTime Birthdate { get; set; }
        [Required]
        public string Address { get; set; }
        public Project Project { get; set; }

        [NotMapped]
        public int Age { get
            {
                return DateTime.Now.Subtract(Birthdate).Days;
            }
            private set { } }
    }
}
