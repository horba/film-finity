using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.DataAccess;
using Entities.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using WebAPI.Models;

namespace WebAPI
{
    public class Startup
    {
        readonly string VueCorsPolicy = "_vueCorsPolicy";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: VueCorsPolicy,
                                  builder =>
                                  {
                                      builder
                                        .AllowAnyHeader()
                                        .AllowAnyMethod()
                                        .AllowCredentials()
                                        .WithOrigins("http://localhost:8080");
                                  });
            });

            services.AddControllers();

            services.AddDbContext<FilmFinityDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("FilmFinityMSSQL"));
            });
            services.AddScoped<CelebrityRepository>();
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

            app.UseCors(VueCorsPolicy);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
