using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Protocols;
using RollOff.Models;
using RollOff.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RollOff
{
    public class Startup
    {
        HttpClient client;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            //var connection = "Data Source = LIN24006509\\SQLEXPRESS; Initial Catalog = Project; Integrated Security = True";
            //services.AddDbContext<ProjectContext>(options => options.UseSqlServer(connection));
            //Uri uri = new Uri("https:local");
            //services.AddHttpClient<IService, RollServices>(c => c.BaseAddress = new Uri(ConfigurationManager.AppSettings["http://localhost:25962"].ToString());
            client = new HttpClient();
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["http://localhost:25962"].ToString());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=SupplyDatums}/{action=Index}/{id?}");
            });
        }
    }
}
