using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace hm02.Models
{
    [Table("Profile")]
    public class Profile
    {
        [Key, Required]
        public Guid Id { get; set; }

        [ForeignKey("Person")]
        public Guid PersonId { get; set; }
        public Person Person { get; set; }
    }
}
