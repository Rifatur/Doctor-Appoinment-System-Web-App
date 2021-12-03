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
    public class ScheduleController : Controller
    {
        private readonly AppDbContext _context;

        public ScheduleController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || id <= 0)
            {
                return BadRequest();
            }
            var GetscheduleData = await _context.Schedules.FirstOrDefaultAsync(e => e.ScheduleID == id);


            return View(GetscheduleData);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Schedule schedule)
        {
            if (!ModelState.IsValid)
            {
                return View(schedule);
            }

            _context.Schedules.Update(schedule);
            await _context.SaveChangesAsync();

            return RedirectToAction("Profile", "Doctor", new { @id = schedule.doctorID });
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || id <= 0)
                BadRequest();

            var ScheduleDataDelete = await _context.Schedules.FirstOrDefaultAsync(e => e.ScheduleID == id);

            if (ScheduleDataDelete == null)
                return NotFound();

            _context.Schedules.Remove(ScheduleDataDelete);
            await _context.SaveChangesAsync();

            return RedirectToAction("Profile", "Doctor", new { @id = ScheduleDataDelete.doctorID });
        }



    }
}
