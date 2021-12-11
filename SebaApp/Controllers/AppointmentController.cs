using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SebaApp.Data;
using SebaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SebaApp.Controllers
{

    public class AppointmentController : Controller
    {
        private readonly AppDbContext _context;

        public AppointmentController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var appointments = await _context.Appointments.ToListAsync();

            var getDoctor = await _context.Doctors.ToListAsync();
            ViewBag.Doctor = new SelectList(getDoctor, "doctorID", "FirstName");

            var getPatient = await _context.Patients.ToListAsync();
            ViewBag.Patient = new SelectList(getPatient, "PatienID", "email");

            return View(appointments);
        }

        public IActionResult Create(int? id , int? patient)
        {

            ViewBag.doctorid = id;
            ViewBag.patient = patient;
             
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Appointment appointment)
        {

            if (!ModelState.IsValid)
            {
                return View(appointment);
            }
           
            _context.Appointments.Add(appointment);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Patient", new { @id = appointment.PatienID });
        }


    }
}
