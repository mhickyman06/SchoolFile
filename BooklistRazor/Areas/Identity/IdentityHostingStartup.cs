using System;
using BooklistRazor.Areas.Identity.Data;
using BooklistRazor.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(BooklistRazor.Areas.Identity.IdentityHostingStartup))]
namespace BooklistRazor.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<BooklistRazorContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("BooklistRazorContextConnection")));

                services.AddDefaultIdentity<BooklistRazorUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<BooklistRazorContext>();
            });
        }
    }
}