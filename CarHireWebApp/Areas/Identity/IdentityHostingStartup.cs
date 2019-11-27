using System;
using CarHireWebApp.Areas.Identity.Data;
using CarHireWebApp.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(CarHireWebApp.Areas.Identity.IdentityHostingStartup))]
namespace CarHireWebApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<CarHireWebAppContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("CarHireWebAppContextConnection")));

                services.AddDefaultIdentity<CarHireWebAppUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<CarHireWebAppContext>();
            });
        }
    }
}