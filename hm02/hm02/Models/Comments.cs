using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace hm02.Models
{
    [Table("Comments")]
    public class Comments
    {
        [Key, Required]
        public Guid Id { get; set; }

        [Required, ForeignKey("Post")]
        public Guid PostId { get; set; }
        public Post Post { get; set; }

        [ForeignKey("ParentCommentId")]
        public Guid ParentId { get; set; }
        public virtual Comments ParentCommentId { get; set; }

        [Required]
        public DateTime DatePosted { get; set; }

        [Required, ForeignKey("PostedBy")]
        public Guid PostedById { get; set; }
        public Person PostedBy { get; set; }

        List<Reaction> Reactions { get; set; }
        List<Comments> CommentsList { get; set; }
    }
}
