using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using Sample.Models;
using SampleApi.Models;
using WebApplication.Services;

namespace WebApplication
{
    public class Startup
    {

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<ISampleRepository, SampleRepository>();
            services.AddTransient<IGeneratePopulation, GeneratePopulation>();
            services.AddTransient<INormalDestribution, NormalDestribution>();
            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // Shows UseCors with CorsPolicyBuilder.
            app.UseCors(builder =>
            builder.WithOrigins("http://localhost:3000"));
          
            app.UseMvcWithDefaultRoute();
        }
    }
}
