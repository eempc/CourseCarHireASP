﻿using CarHireWebApp.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CarHireWebApp.Models;

namespace CarHireWebApp.Models {
    public class CarHireWebAppContext : IdentityDbContext<CarHireWebAppUser>
    {
        public CarHireWebAppContext(DbContextOptions<CarHireWebAppContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<CarHireWebApp.Models.Vehicle> Vehicle { get; set; }

        public DbSet<CarHireWebApp.Models.Booking> Booking { get; set; }


    }
}
