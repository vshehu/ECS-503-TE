using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SEEUShop.Data;
using SEEUShop.Models;
using SEEUShop.ViewModels;

namespace SEEUShop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            return View(await _context.Products.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            CreateProductViewModel model = new CreateProductViewModel();
            model.VATs = _context.VATs.ToList();
            model.Categories = _context.Categories.ToList();

            return View(model);
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateProductViewModel product)
        {
            Product p = new Product();
            p.AmountInStock = product.AmountInStock;
            p.Description = product.Description;
            p.Name = product.Name;
            p.Price = product.Price;
            p.VAT = _context.VATs.Where(x => x.Id == product.VATId).FirstOrDefault();
            p.Category= _context.Categories.Where(x => x.Id == product.CategoryId).FirstOrDefault();


            if (ModelState.IsValid)
            {
                _context.Add(p);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            CreateProductViewModel model = new CreateProductViewModel();

            model.Name = product.Name;
            model.Price = product.Price;
            model.Description = product.Description;
            model.AmountInStock = product.AmountInStock;

            model.VATs = _context.VATs.ToList();
            model.Categories = _context.Categories.ToList();

            return View(model);

             
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CreateProductViewModel product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }


            Product oldProduct = _context.Products.Where(x => x.Id == product.Id).FirstOrDefault();
            oldProduct.Name = product.Name;
            oldProduct.Description = product.Description;
            oldProduct.Price = product.Price;
            oldProduct.AmountInStock = product.AmountInStock;
            oldProduct.Category = _context.Categories.Where(x => x.Id == product.CategoryId).FirstOrDefault();
            oldProduct.VAT = _context.VATs.Where(x => x.Id == product.VATId).FirstOrDefault();
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}
