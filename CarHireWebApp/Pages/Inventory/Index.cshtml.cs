using CarHireWebApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarHireWebApp {
    public class VehicleIndexModel : PageModel
    {
        private readonly CarHireWebApp.Models.CarHireWebAppContext _context;

        public VehicleIndexModel(CarHireWebApp.Models.CarHireWebAppContext context)
        {
            _context = context;
        }

        public IList<Vehicle> Vehicle { get;set; }

        public async Task OnGetAsync()
        {
            Vehicle = await _context.Vehicle.ToListAsync();
        }
    }
}
