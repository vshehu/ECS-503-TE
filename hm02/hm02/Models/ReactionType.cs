using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace hm02.Models
{
    [Table("ReactionType")]
    public class ReactionType
    {
        [Key, Required]
        public Guid Id { get; set; }

        [MaxLength(20)]
        public string TypeName { get; set; }

        [MaxLength]
        public string IconUrl { get; set; }

        public List<Reaction> Reactions { get; set; }
    }
}
