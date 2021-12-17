using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SebaApp.Data;
using SebaApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SebaApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var doctors = await _context.Doctors.ToListAsync();
            ViewBag.Dcount = _context.Doctors.Count();
            ViewBag.Pcount = _context.Patients.Count();
            ViewBag.Aptcount = _context.Appointments.Count();

            //Geting Total Earning
            var Getinvoice = await _context.Invoices.ToListAsync();
            double sum = 0;
            foreach(var item in Getinvoice)
            {
                sum += item.PayableTotal;
            }

            ViewBag.TotalEarn = sum;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
