using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace hm02.Models
{
    [Table("PostImages")]
    public class PostImages
    {
        [Key, Required]
        public Guid Id { get; set; }

        [Required, ForeignKey("Post")]
        public Guid PostId { get; set; }
        public Post Post { get; set; }

        [Required, MaxLength]
        public string FileName { get; set; }

        [Required]
        public bool IsPrimary { get; set; }

        List<Reaction> Reactions { get; set; }
    }
}
