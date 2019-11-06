using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Models
{
    public class Proposal : MyEntity
    {
        public int Id { get; set; }
        public DateTime SubmissionDate { get; set; }
        
        public Boolean Approved { get; set; }
        [MinLength(2)]
        [MaxLength(512)]
        public string RejectedReason { get; set; }
        public DateTime RejectedDate { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(512)]
        public string Description { get; set; }

        public Project Project { get; set; }
    }
}
