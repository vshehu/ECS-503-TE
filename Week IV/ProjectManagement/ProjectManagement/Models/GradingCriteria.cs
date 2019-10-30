using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Models
{
    public class GradingCriteria
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        public List<Grading> Gradings { get; set; }
    }
}
