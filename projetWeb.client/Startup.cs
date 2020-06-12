using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace projetWeb.client
{
    public class Startup
    {
        private IConfiguration config = null;

        public Startup(IConfiguration config)
        {
            this.config = config;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            HttpClient client = new HttpClient();
            // The GetValue<T>() method specifies the key whose value you wish
            // to retrieve and the data type of the value
            string baseUrl = config.GetValue<string>("AppSettings:BaseUrl");
            client.BaseAddress = new Uri(baseUrl);
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);

            // The AddSingleton() method indicates that only one
            // instance of HttpClient will serve all the requests to the object
            services.AddSingleton<HttpClient>(client);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}