using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Models
{
    public class Grading : MyEntity
    {
        public int Id { get; set; }
        public Project Project { get; set; }
        public GradingCriteria Criteria { get; set; }
        [Required]
        public float Grade { get; set; }
        [Required]
        [MinLength(20)]
        [MaxLength(512)]
        public string Comment { get; set; }
    }
}
