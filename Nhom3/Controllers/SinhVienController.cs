using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nhom3.Models;

namespace Nhom3.Controllers
{
    public class SinhVienController : Controller
    {
        private DatabaseContext _context;
        // GET: SinhVien
        public ActionResult Index()
        {
            var sv = _context.SinhVien.ToList();
            return View(sv);
        }

        // GET: SinhVien/Details/5
        public ActionResult Details(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var sv = _context.SinhVien.SingleOrDefault(m => m.MaSV == id);
            if (sv == null) return NotFound();

            return View(sv);
        }

        // GET: SinhVien/Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult<SinhVien>> Create ([Bind("MaSV,HoTen,NgaySinh,DienThoai")] SinhVien sinhVien)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sinhVien);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "SinhVien");
            }
            return View(sinhVien);
        }
        // GET: SinhVien/Edit/5
        public ActionResult Edit(int id)
        {
            SinhVien sv = _context.SinhVien.Where(p => p.MaSV == id).First();
            return View(sv);
        }
        // POST: SinhVien/Edit/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaSV,HoTen,NgaySinh,DienThoai")] SinhVien sinhVien)
        {
            if (id != sinhVien.MaSV)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sinhVien);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SinhVienExists(sinhVien.MaSV))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", "SinhVien");
            }
            return RedirectToAction("Index", "SinhVien");
        }
        // GET: SinhVien/Delete/5
        [HttpGet]
        public async Task<ActionResult<SinhVien>> Delete(int id)
        {
            var sinhVien = await _context.SinhVien.FindAsync(id);
            if (sinhVien == null)
            {
                return NotFound();
            }
            _context.SinhVien.Remove(sinhVien);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "SinhVien");
        }
        private bool SinhVienExists(int id)
        {
            return _context.SinhVien.Any(e => e.MaSV == id);
        }
    }
}
