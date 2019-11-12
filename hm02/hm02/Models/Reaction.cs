using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace hm02.Models
{
    [Table("Reaction")]
    public class Reaction
    {
        [Key, Required]
        public Guid Id { get; set; }

        [ForeignKey("Post")]
        public Guid PostId { get; set; }
        public Post Post { get; set; }

        [ForeignKey("Story")]
        public Guid StoryId { get; set; }
        public Story Story { get; set; }

        [ForeignKey("PostImage")]
        public Guid PostImageId { get; set; }
        public PostImages PostImage { get; set; }

        [ForeignKey("Comment")]
        public Guid CommentId { get; set; }
        public Comments Comment { get; set; }

        [ForeignKey("ReactionType")]
        public Guid ReactionTypeId { get; set; }
        public ReactionType ReactionType { get; set; }

        public DateTime ReactionDate { get; set; }
    }
}
