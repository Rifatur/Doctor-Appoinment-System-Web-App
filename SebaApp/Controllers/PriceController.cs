using Microsoft.AspNetCore.Mvc;
using SebaApp.Data;
using SebaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SebaApp.Controllers
{
    public class PriceController : Controller
    {

        private readonly AppDbContext _context;

        public PriceController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreatePrice()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePrice(VisitingPrice visitingPrice)
        {

            if (!ModelState.IsValid)
            {
                return View(visitingPrice);
            }

            _context.visitingPrices.Add(visitingPrice);
            await _context.SaveChangesAsync();
            return RedirectToAction("Profile", "Doctor", new { @id = visitingPrice.doctorID });
        }
    }
}
