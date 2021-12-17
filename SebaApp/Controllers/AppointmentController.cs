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

            Random rnd = new Random();
            ViewBag.Idvalue = rnd.Next(100000, 999999);

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

            return RedirectToAction("Payment", "Appointment", new { @id = appointment.appointID });
        }

        public IActionResult Payment(int? id)
        {

            var AppointId = id ;
            ViewBag.apnID = AppointId;
            var Getappointments = _context.Appointments.Where(e=>e.appointID == AppointId).FirstOrDefault(); 


            ViewBag.doctorId = Getappointments.doctorID; 
            ViewBag.patientId = Getappointments.PatienID;

            var getPrice = _context.visitingPrices.Where(p => p.doctorID == Getappointments.doctorID).FirstOrDefault();
            ViewBag.cost = getPrice.FirstVisit;
            ViewBag.Total = getPrice.FirstVisit ;

            //Get Patient Info
            var PatientInfo = _context.Patients.Where(x => x.PatienID == Getappointments.PatienID).FirstOrDefault();

            ViewBag.FName = PatientInfo.FirstName;
            ViewBag.LName = PatientInfo.LastName;
            ViewBag.Email = PatientInfo.Email;
            ViewBag.Phone = PatientInfo.mobile;
            //Get Doctor Info
            var DoctorInfo = _context.Doctors.Where(y => y.doctorID == Getappointments.doctorID).FirstOrDefault();
            ViewBag.dFName = DoctorInfo.FirstName;
            ViewBag.dLName = DoctorInfo.LastName;
            //getting Doctor Information
            var doctorinfo =  _context.DoctorInformation.Where(e => e.doctorID == Getappointments.doctorID).FirstOrDefault(); ;
            if (doctorinfo == null)
            {}
            else
            {
                //Doctor personal Information
                ViewBag.SpecialistIn = doctorinfo.SpecialistIn;
            }
            int query = _context.Invoices.Where(x => x.appointID == AppointId).Count();
            ViewBag.invoice = query;

                return View();
        }

        [HttpPost]
        public async Task<IActionResult> Payment(Invoice invoice)
        {
            if (!ModelState.IsValid)
            {
                return View(invoice);
            }
            int query = _context.Invoices.Where(x => x.appointID == invoice.appointID ).Count();

            

            if(query < 1)
            {
                _context.Invoices.Add(invoice);
                await _context.SaveChangesAsync();

            }
            else
            {
                TempData["ErrMessage"] = " Invoice Already Created ..!";
                return RedirectToAction("Payment", "Appointment", new { @id = invoice.appointID });
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Invoice(int? id)
        {
            ViewBag.Invoice = id;

            var Getappoint = _context.Appointments.Where(e => e.appointID == id).FirstOrDefault();


            ViewBag.doctorId = Getappoint.doctorID;
            ViewBag.patientId = Getappoint.PatienID;

            //Get Patient Info
            var PatientInfo = _context.Patients.Where(x => x.PatienID == Getappoint.PatienID).FirstOrDefault();

            ViewBag.FName = PatientInfo.FirstName;
            ViewBag.LName = PatientInfo.LastName;
            ViewBag.Email = PatientInfo.Email;
            ViewBag.Phone = PatientInfo.mobile;





            return View();

        }


    }
}
