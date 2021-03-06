using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Budgey.Infrastructure;
using Budgey.Domain.Interfaces;
using Budgey.Infrastructure.Repositories;
using Budgey.Application;
using Budgey.Application.Interfaces;
using Budgey.Application.Services;
using AutoMapper;

namespace Budgey
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Context>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<Context>();

            services.AddInfrastructure();
            services.AddApplication();
            /*            services.AddScoped<INoteRepository, NoteRepository>();
                        services.AddSingleton<INoteRepository, NoteRepository>();*/
            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "budget",
                    pattern: "budget/BudgetInfo/{id=1}",
                    defaults: new { controller = "Budget", action = "BudgetInfo" });

                endpoints.MapControllerRoute(
                    name: "user",
                    pattern: "user/{action=AllUsers}/{id?}",
                    defaults: new { controller = "User", action = "AllUsers" });

                endpoints.MapControllerRoute(
                    name: "note",
                    pattern: "notes/{action=AllNotes}/{id?}",
                    defaults: new { controller = "Notes", action = "AllNotes" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
