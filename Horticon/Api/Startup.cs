﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using System.Text;
using Data.Context;
using Core.Contracts.Services;
using Core.Contracts.Repositories;
using Service.Services;
using Data.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Cors.Internal;

namespace Api
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
            services.AddCors(); 

            services.AddMvc();  

            services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin",
                    builder => builder.WithOrigins("http://app.horticon.com.br"));
            });

            services.AddMvc().  SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // # Depedency Injection
            services.AddTransient<MySqlContext, MySqlContext>();

            services.AddTransient<ICycleService, CycleService>();
            services.AddTransient<ICycleRepository, CycleRepository>();

            services.AddTransient<IPesticideService, PesticideService>();
            services.AddTransient<IPesticideRepository, PesticideRepository>();

            services.AddTransient<IPlantingService, PlantingService>();
            services.AddTransient<IPlantingRepository, PlantingRepository>();

            services.AddTransient<IWashingPipeService, WashingPipeService>();
            services.AddTransient<IWashingPipeRepository, WashingPipeRepository>();

            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserRepository, UserRepository>();

            services.AddTransient<IWaterControlService, WaterControlService>();
            services.AddTransient<IWaterControlRepository, WaterControlRepository>();

            services.AddTransient<IWaterChangeService, WaterChangeService>();
            services.AddTransient<IWaterChangeRepository, WaterChangeRepository>();


            // # Start cnofig mysql
            var connection = Configuration["ConectionMySql:MySqlConnectionString"];

            services.AddDbContext<MySqlContext>(options => options.UseMySql("server=mysql.horticon.com.br;user id=horticon;password=homhorticon2018;persistsecurityinfo=True; database=horticon"));

            // # Start config jwt
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidIssuer = Configuration["Authentication:Issuer"],

                        ValidateAudience = true,
                        ValidAudience = Configuration["Authentication:Audience"],

                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Authentication:SecretKey"])),

                        RequireExpirationTime = true,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero
                    };
                });


            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "Horticon API",
                    Description = "Gerenciamento de plantações hidropônicas",
                    Contact = new Contact
                    {
                        Name = "Smael Munari da Rosa",
                        Email = "smunari@gmail.com",
                        Url = "https://twitter.com/smaelmr"
                    }
                });


                c.AddSecurityDefinition("Bearer", new ApiKeyScheme()
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                    Name = "Authorization",
                    In = "header",
                    Type = "apiKey"
                });
                c.AddSecurityRequirement(new Dictionary<string, IEnumerable<string>>
                {
                    { "Bearer", new string[] { } }
                });

                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);

            });
        }

       
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseAuthentication();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                // Enable middleware to serve generated Swagger as a JSON endpoint.
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Horticon V1");
                    c.RoutePrefix = string.Empty;

                });
            }
            else
                app.UseHsts();

            app.UseHttpsRedirection();
            

            // Shows UseCors with named policy.
            app.UseCors("AllowSpecificOrigin");
            app.UseCors(option =>option.AllowAnyOrigin());  
            app.UseCors(option => option.AllowAnyMethod());
            app.UseCors(option => option.AllowAnyHeader()); 
            app.UseCors(option => option.AllowCredentials());  

            app.UseMvc();

            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
