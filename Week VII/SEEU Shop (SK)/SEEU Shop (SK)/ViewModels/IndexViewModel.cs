using SEEU_Shop__SK_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEEU_Shop__SK_.ViewModels
{
    public class IndexViewModel
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
    }
}
