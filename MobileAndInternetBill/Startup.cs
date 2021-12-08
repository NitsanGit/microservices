using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Microsoft.OpenApi.Models;


namespace MobileAndInternetBill
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
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Mobile And Internet Bill APIs", Version = "v1" });
                
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger( c=>
            {
             //   c.RouteTemplate="mobilebill/swagger/MobileBill/swagger.json";
            });
            
            app.UseSwaggerUI(c => {


                c.RoutePrefix = "swagger";
                c.SwaggerEndpoint("v1/swagger.json", "Mobile and Internet Bill API V1");

             //   c.SwaggerEndpoint("/mobilebill/swagger/v1/swagger.json", "MobileAndInternetBill v1");
             //   c.RoutePrefix = "/mobilebill";
            });
          
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}