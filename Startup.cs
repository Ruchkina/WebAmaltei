using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppAmalt.Repository;
using DatabaseContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AppAmalt
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
            var connectionString = "User ID=postgres; Password=123; Server=localhost; Port=5432; Database=App";
            services.AddControllers();
            services.AddScoped<IResponseRepository, ResponseRepository>();
            services.AddScoped<IAgeRepository, AgeRepository>();
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<IGenderRepository, GenderRepository>();
            services.AddScoped<ILifeMainRepository, LifeMainRepository>();
            services.AddScoped<IPoliticalRepository, PoliticalRepository>();
            services.AddScoped<IPortraitRepository, PortraitRepository>();
            services.AddScoped<IRelationRepository, RelationRepository>();
            services.AddScoped<IEducationRepository, EducationRepository>();
            services.AddEntityFrameworkNpgsql().AddDbContext<DatabaseContexts>(options =>
                options.UseNpgsql(connectionString/*, x => x.MigrationsAssembly("StackOverflow.WebService")*/));

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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
