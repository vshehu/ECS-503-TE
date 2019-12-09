﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SEEU_Shop__SK_.Data;
using SEEU_Shop__SK_.Models;

namespace SEEU_Shop__SK_.Controllers
{
    public class VATsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VATsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: VATs
        public async Task<IActionResult> Index()
        {
            return View(await _context.VATs.ToListAsync());
        }

        // GET: VATs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vAT = await _context.VATs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vAT == null)
            {
                return NotFound();
            }

            return View(vAT);
        }

        // GET: VATs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VATs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Amount")] VAT vAT)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vAT);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vAT);
        }

        // GET: VATs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vAT = await _context.VATs.FindAsync(id);
            if (vAT == null)
            {
                return NotFound();
            }
            return View(vAT);
        }

        // POST: VATs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Amount")] VAT vAT)
        {
            if (id != vAT.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vAT);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VATExists(vAT.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(vAT);
        }

        // GET: VATs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vAT = await _context.VATs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vAT == null)
            {
                return NotFound();
            }

            return View(vAT);
        }

        // POST: VATs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vAT = await _context.VATs.FindAsync(id);
            _context.VATs.Remove(vAT);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VATExists(int id)
        {
            return _context.VATs.Any(e => e.Id == id);
        }
    }
}
