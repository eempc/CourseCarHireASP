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
    public class VehicleDetailsModel : PageModel
    {
        private readonly CarHireWebApp.Models.CarHireWebAppContext _context;

        public VehicleDetailsModel(CarHireWebApp.Models.CarHireWebAppContext context)
        {
            _context = context;
        }

        public Vehicle Vehicle { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Vehicle = await _context.Vehicle.FirstOrDefaultAsync(m => m.VehicleId == id);

            if (Vehicle == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
