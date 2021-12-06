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
    public class PatientController : Controller
    {
        private readonly AppDbContext _context;

        public PatientController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var patients = await _context.Patients.ToListAsync();

            return View(patients);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Patient patient)
        {
            if (ModelState.IsValid)
            {
                _context.Patients.Add(patient);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(patient);
        }



        public async Task<IActionResult> Details(int? id)
        {

            
            
            if (id == null || id <= 0)
            {
                return BadRequest();
            }
            

            var GetPatientdata = await _context.Patients.FirstOrDefaultAsync(e => e.PatienID == id);
            //Geting doctor List into patient profile
            var doctors = await _context.Doctors.ToListAsync();

            var PatientAppointment = await _context.Appointments.Where(e => e.PatienID == id).ToListAsync();

            Patient ViewProfileDetails = new Patient();
            ViewProfileDetails.PatienID = GetPatientdata.PatienID;
            ViewProfileDetails.FirstName = GetPatientdata.FirstName;
            ViewProfileDetails.LastName = GetPatientdata.LastName;
            ViewProfileDetails.Email = GetPatientdata.Email;
            ViewProfileDetails.Password = GetPatientdata.Password;
            ViewProfileDetails.mobile = GetPatientdata.mobile;
            ViewProfileDetails.Token = GetPatientdata.Token;
            ViewProfileDetails.PatienCard = GetPatientdata.PatienCard;
            ViewProfileDetails.Status = GetPatientdata.Status;






            ViewData["doctors"] = doctors;


            
            //Getting Schedule List
            if (PatientAppointment == null)
            {

            }
            else
            {
                ViewData["Appoinment"] = PatientAppointment;
            }

           

            return View(ViewProfileDetails);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || id <= 0)
                BadRequest();

            var PatientDataDelete = await _context.Patients.FirstOrDefaultAsync(e => e.PatienID == id);

            if (PatientDataDelete == null)
                return NotFound();

            _context.Patients.Remove(PatientDataDelete);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }





    }
}
