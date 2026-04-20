using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BaiTap_MVC.Models;

namespace BaiTap_MVC.Controllers
{
    public class DangKyHocsController : Controller
    {
        private readonly AppDbContext _context;

        public DangKyHocsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: DangKyHocs
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.DangKyHocs.Include(d => d.LopHocPhan).Include(d => d.SinhVien);
            return View(await appDbContext.ToListAsync());
        }

        // GET: DangKyHocs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dangKyHoc = await _context.DangKyHocs
                .Include(d => d.LopHocPhan)
                .Include(d => d.SinhVien)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dangKyHoc == null)
            {
                return NotFound();
            }

            return View(dangKyHoc);
        }

        // GET: DangKyHocs/Create
        public IActionResult Create()
        {
            ViewData["LopHocPhanId"] = new SelectList(_context.LopHocPhans, "Id", "Id");
            ViewData["SinhVienId"] = new SelectList(_context.SinhViens, "Id", "Id");
            return View();
        }

        // POST: DangKyHocs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SinhVienId,LopHocPhanId")] DangKyHoc dangKyHoc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dangKyHoc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LopHocPhanId"] = new SelectList(_context.LopHocPhans, "Id", "Id", dangKyHoc.LopHocPhanId);
            ViewData["SinhVienId"] = new SelectList(_context.SinhViens, "Id", "Id", dangKyHoc.SinhVienId);
            return View(dangKyHoc);
        }

        // GET: DangKyHocs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dangKyHoc = await _context.DangKyHocs.FindAsync(id);
            if (dangKyHoc == null)
            {
                return NotFound();
            }
            ViewData["LopHocPhanId"] = new SelectList(_context.LopHocPhans, "Id", "Id", dangKyHoc.LopHocPhanId);
            ViewData["SinhVienId"] = new SelectList(_context.SinhViens, "Id", "Id", dangKyHoc.SinhVienId);
            return View(dangKyHoc);
        }

        // POST: DangKyHocs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SinhVienId,LopHocPhanId")] DangKyHoc dangKyHoc)
        {
            if (id != dangKyHoc.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dangKyHoc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DangKyHocExists(dangKyHoc.Id))
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
            ViewData["LopHocPhanId"] = new SelectList(_context.LopHocPhans, "Id", "Id", dangKyHoc.LopHocPhanId);
            ViewData["SinhVienId"] = new SelectList(_context.SinhViens, "Id", "Id", dangKyHoc.SinhVienId);
            return View(dangKyHoc);
        }

        // GET: DangKyHocs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dangKyHoc = await _context.DangKyHocs
                .Include(d => d.LopHocPhan)
                .Include(d => d.SinhVien)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dangKyHoc == null)
            {
                return NotFound();
            }

            return View(dangKyHoc);
        }

        // POST: DangKyHocs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dangKyHoc = await _context.DangKyHocs.FindAsync(id);
            if (dangKyHoc != null)
            {
                _context.DangKyHocs.Remove(dangKyHoc);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DangKyHocExists(int id)
        {
            return _context.DangKyHocs.Any(e => e.Id == id);
        }
    }
}
