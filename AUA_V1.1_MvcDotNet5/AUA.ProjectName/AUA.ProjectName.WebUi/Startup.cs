using System;
using AUA.ProjectName.DataLayer.AppContext.EntityFrameworkContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AUA.ProjectName.WebUi.AppConfiguration;
using AUA.ProjectName.WebUI.Areas.Shop.Data;
using AUA.ProjectName.WebUI.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace AUA.ProjectName.WebUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.Configuration();

            services.AddDbContext<AUAProjectNameWebUIContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("AUAProjectNameWebUIContext")));



        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            //In AUA Framework ExceptionHandler not free 

            app.UseDeveloperExceptionPage();

            app.Configuration();


        }
    }
}
