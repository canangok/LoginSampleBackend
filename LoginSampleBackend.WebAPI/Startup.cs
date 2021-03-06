using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginSampleBackend.Business.Abstract;
using LoginSampleBackend.Business.Concrete;
using LoginSampleBackend.DataAccess.Abstract;
using LoginSampleBackend.DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace LoginSampleBackend.WebAPI
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
            services.AddCors(x => x.AddPolicy("test", opt =>
            {
                opt.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
            }));
            services.AddScoped<IUserAccountService, UserAccountManager>(); 
            //Biri IUserAccountService �eklinde bir �ey isterse biz ona UserAccountManager veriyor olaca��z.
            services.AddScoped<IUserAccountDal, EfUserAccountDal>(); //

            services.AddControllers();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("test");
            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
