using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testapp3.Modals.DBAuth;
using testapp3.Repositories.Implements;
using testapp3.Repositories.Interfaces;
using testapp3.Services.Implements;
using testapp3.Services.InterFaces;

namespace testapp3
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
            //for allow origin
            services.AddCors();

            services.AddDbContext<DBAuthContext>(options => options.UseMySQL(Configuration.GetConnectionString("default")));
            //for dependency injection
            services.AddTransient<IEmployee,EmployeeImpl>();
            services.AddTransient<IEmployeeRepo,EmployeeRepoImpl>();

            services.AddTransient<IUser,UserImpl>();
            services.AddTransient<IUserRepo,UserRepoImpl>();

            services.AddTransient<ITeam, TeamImpl>();
            services.AddTransient<ITeamRepo, TeamRepoImpl>();

            services.AddTransient<ITrophy, TrophyImpl>();
            services.AddTransient<ITrophyRepo,TrophyRepoImpl>();
            //end of dependency injection

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "testapp3", Version = "v1" });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //for allow origin
            app.UseCors(options =>
            {
                options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "testapp3 v1"));
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
