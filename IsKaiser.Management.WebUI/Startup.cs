using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.AspNetCore;
using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Bll.Concrete;
using IsKaiser.Management.Bll.ValidationRules.FluentValidation;
using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Dal.Concrete.EntityFramework;
using IsKaiser.Management.Entities.Concrete;
using IsKaiser.Management.WebUI.Utilities.FileConverter.Abstract;
using IsKaiser.Management.WebUI.Utilities.FileConverter.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;


namespace IsKaiser.Management.WebUI
{
    public class Startup
    {
      
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().AddFluentValidation();
         
            services.AddScoped<IUserDal, EfUserDal>();
            services.AddScoped<IAffairDal, EfAffairDal>();
            services.AddScoped<ICustomerDal, EfCustomerDal>();
            services.AddScoped<IEmployeeDal, EfEmployeeDal>();
            services.AddScoped<IVehicleDal, EfVehicleDal>();

            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IAffairService, AffairManager>();
            services.AddScoped<ICustomerService, CustomerManager>();
            services.AddScoped<IEmployeeService, EmployeeManager>();
            services.AddScoped<IVehicleService, VehicleManager>();

            services.AddScoped<IConverter, SvgConverter>();

            services.AddScoped<IValidator<Affair>, AffairValidator>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc(ConfigureRoutes);
            app.UseStaticFiles();
         
        }
        void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute("default", "{controller=User}/{action=Login}/{id?}");
        }
    }
}
