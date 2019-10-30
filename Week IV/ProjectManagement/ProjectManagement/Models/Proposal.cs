using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Models
{
    public class Proposal
    {
        public int Id { get; set; }
        public DateTime SubmissionDate { get; set; }
        public Boolean Approved { get; set; }
        public string RejectedReason { get; set; }
        public DateTime RejectedDate { get; set; }
        public string Description { get; set; }

        public Project Project { get; set; }
    }
}
