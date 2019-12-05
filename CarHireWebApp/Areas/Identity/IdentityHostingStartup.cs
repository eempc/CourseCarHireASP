using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(CarHireWebApp.Areas.Identity.IdentityHostingStartup))]
namespace CarHireWebApp.Areas.Identity {
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            //builder.ConfigureServices((context, services) => {
            //    services.AddDbContext<CarHireWebAppContext>(options =>
            //        options.UseSqlServer(
            //            context.Configuration.GetConnectionString("CarHireWebAppContextConnection")));

            //    services.AddDefaultIdentity<CarHireWebAppUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //        .AddEntityFrameworkStores<CarHireWebAppContext>();
            //});
        }
    }
}