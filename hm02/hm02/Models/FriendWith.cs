using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace hm02.Models
{
    [Table("FriendWith")]
    public class FriendWith
    {
        [Key, Required]
        public Guid Id { get; set; }

        [Required, ForeignKey("Chat")]
        public Guid ChatId { get; set; }
        public Chat Chat { get; set; }

        [Required]
        public DateTime Friendaversary { get; set; }
    }
}
