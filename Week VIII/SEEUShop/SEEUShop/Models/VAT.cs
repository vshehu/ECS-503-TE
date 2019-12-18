using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEEUShop.Models
{
    public class VAT
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public List<Product> Products { get; set; }
    }
}
