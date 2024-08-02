using Elfie.Serialization;
using Microsoft.Data.SqlClient;
using System;
using System.Data.SqlTypes;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace ModelBindingToDo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Employess}/{action=Index}/{id?}");

            Connect();

            app.Run();
        }
     static void Connect()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString= @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = YcpOct23; Integrated Security = True";
            try
            {
                cn.Open();
                Console.WriteLine("Success");
            }
            catch(Exception )
            {
                throw;

            }
            finally { cn.Close(); }
        }
    }
}