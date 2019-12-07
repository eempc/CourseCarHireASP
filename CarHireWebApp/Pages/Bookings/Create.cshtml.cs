using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CarHireWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace CarHireWebApp {
    [Authorize]
    public class BookingCreateModel : PageModel {
        private readonly CarHireWebApp.Models.CarHireWebAppContext _context;

        public BookingCreateModel(CarHireWebApp.Models.CarHireWebAppContext context) {
            _context = context;
        }

        public IActionResult OnGet() {
            //ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["VehicleId"] = new SelectList(_context.Vehicle, "VehicleId", "Make");
            return Page();
        }

        [BindProperty]
        public Booking Booking { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync() {
            Booking.DateCreated = DateTime.Now;
            Booking.UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (!ModelState.IsValid) {
                return Page();
            }

            _context.Booking.Add(Booking);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
