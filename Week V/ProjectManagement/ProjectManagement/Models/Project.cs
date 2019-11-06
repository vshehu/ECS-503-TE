using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Models
{
    public class Project : MyEntity
    {
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(512)]
        public string Description { get; set; }
        public DateTime DateOfSubmission { get; set; }

        public List<Student> Students { get; set; }
        public List<Proposal> Proposals { get; set; }
        public List<Grading> Gradings { get; set; }
    }
}
