using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NewsClassNet6.Models;
using NewsClassNet6.Repository;
using System.Security.Principal;

namespace NewsClassNet6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            //Built in need to register
            builder.Services.AddControllersWithViews();
            //.AddSessionStateTempDataProvider();

            builder.Services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });
            builder.Services.AddDbContext<Entity>(optionBuilder => {
                optionBuilder.UseSqlServer("Data Source=.;Initial Catalog=Intake42Q3Assiut;Integrated Security=True");
            });
            //register usermanager,rolemanager==>userrole
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>(
                options => options.Password.RequireDigit = true
                ).
                AddEntityFrameworkStores<Entity>();

            //Custom Service --REgister
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<INewsRepository, NewsRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();//requet
            app.UseAuthorization();
            app.UseSession();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}