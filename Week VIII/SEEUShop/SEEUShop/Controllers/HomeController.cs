using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEEUShop.Data;
using SEEUShop.Models;
using SEEUShop.ViewModels;

namespace SEEUShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? id)
        {
            IndexViewModel model = new IndexViewModel();
            model.Categories = _context.Categories.ToList();
            if (id == null)
            {                
                model.Products = _context.Products.ToList();
            }
            else
            {
                model.Products = _context.Products.Where(x => x.Category.Id == id).ToList();
            }
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
