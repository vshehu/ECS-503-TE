using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace hm02.Models
{
    [Table("Post")]
    public class Post
    {
        [Key, Required]
        public Guid Id { get; set; }

        [ForeignKey("Person")]
        public Guid PersonId { get; set; }
        public Person Person { get; set; }

        [Required, MaxLength]
        public string PostContent { get; set; }

        [Required]
        public DateTime PostedDate { get; set; }

        public List<PostImages> PostImages { get; set; }
        public List<Reaction> Reactions { get; set; }
    }
}