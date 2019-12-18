using SEEUShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEEUShop.ViewModels
{
    public class CreateProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        [Display(Name="Amount in stock")]
        public decimal AmountInStock { get; set; }

        public int CategoryId { get; set; }
        public int VATId { get; set; }

        public List<Category> Categories { get; set; }
        public List<VAT> VATs { get; set; }
    }
}
