using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using StaffsApi.Model;
using StaffsApi.Repositary;
using StaffsApi.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffsApi
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "StaffsApi", Version = "v1" });
            });

            services.AddScoped<ICourse<Course>, Course>();
            services.AddScoped<ICourseRepo<Course>, CourseRepo>();
            services.AddScoped<ICourseServ<Course>, CourseServ>();

            services.AddScoped<ITopic<Topic>, Topic>();
            services.AddScoped<ITopicRepo<Topic>, TopicRepo>();
            services.AddScoped<ITopicServ<Topic>, TopicServ>();

            services.AddScoped<IClass<Class>, Class>();
            services.AddScoped<IClassRepo<Class>, ClassRepo>();
            services.AddScoped<IClassServ<Class>, ClassServ>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            
            loggerFactory.AddLog4Net();
	          
	
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "StaffsApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
