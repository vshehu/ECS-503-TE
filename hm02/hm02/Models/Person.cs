using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace hm02.Models
{
    [Table("Person")]
    public class Person
    {
        [Key, Required]
        public Guid Id { get; set; }

        [Required, MaxLength(20)]
        public string Name { get; set; }

        [Required, MaxLength(20)]
        public string LastName { get; set; }

        [MaxLength(20)]
        public string Address { get; set; }

        [MaxLength(50)]
        public int PhoneNumber { get; set; }

        [Required, MaxLength(50)]
        public string Email { get; set; }

        [Required, MaxLength(255)]
        public string Password { get; set; }

        [ForeignKey("Profile")]
        public Guid ProfileId { get; set; }
        public Profile Profile { get; set; }

        public List<Post> Posts { get; set; }
        public List<Story> Stories { get; set; }
        public List<Comments> Comments { get; set; }
        public List<FriendWith> FirstPerson { get; set; }
        public List<FriendWith> FriendsWith { get; set; }
    }
}
