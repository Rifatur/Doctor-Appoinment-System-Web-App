using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SebaApp.Data;
using SebaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SebaApp.Controllers
{
    public class DoctorController : Controller
    {

        private readonly AppDbContext _context;

        public DoctorController(AppDbContext context)
        {
            _context = context;
        }
        public async  Task<IActionResult> Index()
        {
            var doctors = await _context.Doctors.ToListAsync();

            return View(doctors);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Doctor doctors)
        {
            if (ModelState.IsValid)
            {
                _context.Doctors.Add(doctors);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(doctors);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || id <= 0)
            {
                return BadRequest();
            }
            var DoctorDataSourch = await _context.Doctors.FirstOrDefaultAsync(e => e.doctorID == id);
            if (DoctorDataSourch == null)
            {
                return NotFound();
            }

            return View(DoctorDataSourch);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Doctor doctors)
        {
            if (!ModelState.IsValid)
            {
                return View(doctors);
            }

            _context.Doctors.Update(doctors);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || id <= 0)
                BadRequest();

            var DoctorDataDelete = await _context.Doctors.FirstOrDefaultAsync(e => e.doctorID == id);

            if (DoctorDataDelete == null)
                return NotFound();

            _context.Doctors.Remove(DoctorDataDelete);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }




        public async Task<IActionResult> Profile(int? id)
        {
            if (id == null || id <= 0)
            {
                return BadRequest();
            }
            var DoctorProfileData = await _context.Doctors.FirstOrDefaultAsync(e => e.doctorID == id);

            Doctor ViewProfileDetails = new Doctor();

            ViewProfileDetails.doctorID = DoctorProfileData.doctorID;
            ViewProfileDetails.FirstName = DoctorProfileData.FirstName;
            ViewProfileDetails.LastName = DoctorProfileData.LastName;
            ViewProfileDetails.Email = DoctorProfileData.Email;
            ViewProfileDetails.Password = DoctorProfileData.Password;
            ViewProfileDetails.mobile = DoctorProfileData.mobile;
            ViewProfileDetails.Status = DoctorProfileData.Status;


            return View(ViewProfileDetails);
        }

    }
}
