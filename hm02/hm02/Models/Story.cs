using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace hm02.Models
{
    [Table("Story")]
    public class Story
    {
        [Key, Required]
        public Guid Id { get; set; }

        [ForeignKey("Person")]
        public Guid PersonId { get; set; }
        public Person Person { get; set; }

        [Required, MaxLength(30)]
        public string ImageName { get; set; }

        [Required]
        public DateTime PostTime { get; set; }
        [Required]
        public DateTime ExpireTime { get; set; }
        public List<Reaction> Reactions { get; set; }
    }
}
