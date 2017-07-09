using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Konf_ADM.Data;
using Konf_ADM.Models;

namespace Konf_ADM.Controllers
{
    public class KonfirmandsController : Controller
    {
        private readonly KonfirmandContext _context;

        public KonfirmandsController(KonfirmandContext context)
        {
            _context = context;    
        }

        // GET: Konfirmands
        public async Task<IActionResult> Index()
        {
            return View(await _context.konfirmander.ToListAsync());
        }

        // GET: Konfirmands/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var konfirmand = await _context.konfirmander
                .SingleOrDefaultAsync(m => m.ID == id);
            if (konfirmand == null)
            {
                return NotFound();
            }

            return View(konfirmand);
        }

        // GET: Konfirmands/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Konfirmands/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,KonfirmandholdID,Name,BirthDay,Baptized,Address,Phone")] Konfirmand konfirmand)
        {
            if (ModelState.IsValid)
            {
                _context.Add(konfirmand);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(konfirmand);
        }

        // GET: Konfirmands/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var konfirmand = await _context.konfirmander.SingleOrDefaultAsync(m => m.ID == id);
            if (konfirmand == null)
            {
                return NotFound();
            }
            return View(konfirmand);
        }

        // POST: Konfirmands/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,KonfirmandholdID,Name,BirthDay,Baptized,Address,Phone")] Konfirmand konfirmand)
        {
            if (id != konfirmand.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(konfirmand);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KonfirmandExists(konfirmand.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(konfirmand);
        }

        // GET: Konfirmands/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var konfirmand = await _context.konfirmander
                .SingleOrDefaultAsync(m => m.ID == id);
            if (konfirmand == null)
            {
                return NotFound();
            }

            return View(konfirmand);
        }

        // POST: Konfirmands/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var konfirmand = await _context.konfirmander.SingleOrDefaultAsync(m => m.ID == id);
            _context.konfirmander.Remove(konfirmand);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool KonfirmandExists(int id)
        {
            return _context.konfirmander.Any(e => e.ID == id);
        }
    }
}
