using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Entities.DataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using WebAPI.Models;
using Entities.Models;
using WebAPI.Services;
using WebAPI.Repositories;
using WebAPI.Mapping;
using AutoMapper;

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

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddScoped<NewsRepository>();
            services.AddScoped<NewsService>();

            services.AddControllers();
            services.AddDirectoryBrowser();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("FilmFinity", new OpenApiInfo { Title = "FilmFinity API", Version = "v1" });
            });

            services.AddDbContext<FilmFinityDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("FilmFinityMSSQL"));
            });
        }

 
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/FilmFinity/swagger.json", "FilmFinity API");
                c.RoutePrefix = string.Empty;
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(VueCorsPolicy);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseStaticFiles();
            app.UseFileServer(new FileServerOptions
            {
                FileProvider = new PhysicalFileProvider(
            Path.Combine(Directory.GetCurrentDirectory(), "StaticFiles")),
                RequestPath = "/StaticFiles",
                EnableDirectoryBrowsing = true
            });
        }
    }
}
