﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Models
{
    public class Grading
    {
        public int Id { get; set; }
        public Project Project { get; set; }
        public GradingCriteria Criteria { get; set; }
        public float Grade { get; set; }
        public string Comment { get; set; }
    }
}
