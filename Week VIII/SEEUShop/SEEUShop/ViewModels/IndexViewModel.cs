using SEEUShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEEUShop.ViewModels
{
    public class IndexViewModel
    {
        public List<Category>   Categories { get; set; }
        public List<Product> Products { get; set; }
    }
}
