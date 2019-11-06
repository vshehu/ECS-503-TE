using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Models
{
    public class GradingCriteria : MyEntity
    {
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        public string Name { get; set; }
        [Range(0,100)]
        public int Points { get; set; }
        public List<Grading> Gradings { get; set; }
    }
}
