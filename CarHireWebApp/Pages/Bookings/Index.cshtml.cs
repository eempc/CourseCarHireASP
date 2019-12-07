using CarHireWebApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarHireWebApp {
    public class BookingIndexModel : PageModel {
        private readonly CarHireWebAppContext _context;

        public BookingIndexModel(CarHireWebAppContext context) {
            _context = context;
        }

        public IList<Booking> Booking { get; set; }

        public async Task OnGetAsync() {
            Booking = await _context.Booking
                .Include(b => b.User)
                .Include(b => b.Vehicle).ToListAsync();
        }
    }
}
