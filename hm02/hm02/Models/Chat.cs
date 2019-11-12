using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace hm02.Models
{
    [Table("Chat")]
    public class Chat
    {
        [Key, Required]
        public Guid Id { get; set; }

        public List<Message> Messages { get; set; }

        [ForeignKey("FriendWith")]
        public Guid FriendWithId { get; set; }
        public virtual FriendWith FriendWith { get; set; }
    }
}
