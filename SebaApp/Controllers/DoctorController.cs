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
            //getting Doctor Information
            var doctorinformation = await _context.DoctorInformation.FirstOrDefaultAsync(i => i.doctorID == id);
            //getting Doctor Schedules
            var doctorschedule = await _context.Schedules.FirstOrDefaultAsync(i => i.doctorID == id);

            ViewBag.infocount = _context.DoctorInformation.Count();


            Doctor ViewProfileDetails = new Doctor();

            ViewProfileDetails.doctorID = DoctorProfileData.doctorID;
            ViewProfileDetails.FirstName = DoctorProfileData.FirstName;
            ViewProfileDetails.LastName = DoctorProfileData.LastName;
            ViewProfileDetails.Email = DoctorProfileData.Email;
            ViewProfileDetails.Password = DoctorProfileData.Password;
            ViewProfileDetails.mobile = DoctorProfileData.mobile;
            ViewProfileDetails.Status = DoctorProfileData.Status;

            //Doctor personal Information
            ViewBag.SpecialistIn = doctorinformation.SpecialistIn;
            ViewBag.Experiance = doctorinformation.Experiance;
            ViewBag.About = doctorinformation.About;
            ViewBag.Hospital = doctorinformation.Hospital;
            ViewBag.officeAddress = doctorinformation.officeAddress;
            ViewBag.MailingAddress = doctorinformation.MailingAddress;
            ViewBag.Country = doctorinformation.Country;
            ViewBag.State = doctorinformation.State;
            ViewBag.City = doctorinformation.City;
            ViewBag.Area = doctorinformation.Area;
            ViewBag.DateofBirth = doctorinformation.DateofBirth;
            ViewBag.Gender = doctorinformation.Gender;
            ViewBag.Nid = doctorinformation.Nid;
            ViewBag.Nationality = doctorinformation.Nationality;
            ViewBag.doctorID = doctorinformation.doctorID;

            //Doctor Show Schedule


            return View(ViewProfileDetails);
        }

        //Create Information
        [HttpPost]
        public IActionResult DoctorInformation(DoctorInformation doctorInformation )
        {

            _context.DoctorInformation.Add(new DoctorInformation()
            {

                SpecialistIn = doctorInformation.SpecialistIn,
                Experiance = doctorInformation.Experiance,
                About = doctorInformation.About,
                Hospital = doctorInformation.Hospital,
                officeAddress = doctorInformation.officeAddress,
                MailingAddress = doctorInformation.MailingAddress,
                Country = doctorInformation.Country,
                State = doctorInformation.State,
                City = doctorInformation.City,
                Area = doctorInformation.Area,
                DateofBirth = doctorInformation.DateofBirth,
                Gender = doctorInformation.Gender,
                Nid = doctorInformation.Nid,
                Nationality = doctorInformation.Nationality,
                doctorID = doctorInformation.doctorID
            });

            _context.SaveChanges();

            return RedirectToAction("Profile", "Doctor", new { @id = doctorInformation.doctorID });
        }

        [HttpPost]
        public IActionResult CreateSchedule(Schedule schedule)
        {

            _context.Schedules.Add(new Schedule()
            {
                SetDay = schedule.SetDay,
                SetTime = schedule.SetTime,
                doctorID = schedule.doctorID

            });
            _context.SaveChanges();
            return RedirectToAction("Profile", "Doctor", new { @id = schedule.doctorID });
        }



    }




}
