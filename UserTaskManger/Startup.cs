﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using DAL.Database;
using DAL.Interfaces;
using BAL;
using BAL.Interfaces;
using DAL.Repository;
using DAL;
using Microsoft.AspNetCore.Mvc.Cors.Internal;

namespace UserTaskManger
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
            //services.AddCors();
            services.AddCors(options =>
            {
                options.AddPolicy("AllowMyOrigin",
                builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().AllowCredentials().Build());
            });
            services.AddDbContext<DatabaseContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DatabaseConnection")));
            
            services.AddTransient<IDatabaseAutomapperConfiguration, DatabaseAutomapperConfiguration>();
            services.AddTransient<ITaskRepository,TaskRepository>();
            services.AddTransient<ITaskBusinessLogic, TaskBusinessLogic>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUserBusinessLogic, UserBusinessLogic>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.Configure<MvcOptions>(options =>
            {
                options.Filters.Add(new CorsAuthorizationFilterFactory("AllowMyOrigin"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseCors("AllowMyOrigin");
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
