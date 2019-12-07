using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarHireWebApp.Models;

namespace CarHireWebApp
{
    public class BookingDetailsModel : PageModel
    {
        private readonly CarHireWebApp.Models.CarHireWebAppContext _context;

        public BookingDetailsModel(CarHireWebApp.Models.CarHireWebAppContext context)
        {
            _context = context;
        }

        public Booking Booking { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Booking = await _context.Booking
                .Include(b => b.User)
                .Include(b => b.Vehicle).FirstOrDefaultAsync(m => m.BookingId == id);

            if (Booking == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
