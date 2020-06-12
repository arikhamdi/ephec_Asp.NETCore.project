using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using projetWeb.Models;
using Microsoft.AspNetCore.Http;
using projetWeb.Repositories;

namespace projetWeb
{
    public class Startup
    {
        private IConfiguration config = null;

        public Startup(IConfiguration config)
        {
            this.config = config;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContext<AppDbContext>(options => 
                options.UseSqlServer(this.config.GetConnectionString("AppDb")));

            // Registering Repositories : The AddScoped() method creates an instance of a
            // specified type and sets its lifetime to be the current request.
            // That mean anytime during a request, the same object instance
            // will be supplied by the DI container
            services.AddScoped<IEstablishmentRepository, EstablishmentSqlRepository>();
            services.AddScoped<ICountryRepository, CountrySqlRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}
