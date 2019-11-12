using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace hm02.Models
{
    [Table("Message")]
    public class Message
    {
        public enum MessageStatus
        {
            Sent,
            Delivered
        }
        [Key, Required]
        public Guid Id { get; set; }

        [MaxLength(255)]
        public string MessageContent { get; set; }

        [Required]
        public MessageStatus Status { get; set; }

        [Required]
        public DateTime MessageCreated { get; set; }

        [Required, ForeignKey("Chat")]
        public Guid ChatId { get; set; }
        public Chat Chat { get; set; }
    }
}
