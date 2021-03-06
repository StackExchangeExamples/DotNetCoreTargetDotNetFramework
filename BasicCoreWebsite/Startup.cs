using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace BasicCoreWebsite {
  public class Startup {

    public void ConfigureServices(IServiceCollection services) {
      services.AddControllers();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
      app.UseRouting();
      app.UseEndpoints(endpoints => {
        endpoints.MapDefaultControllerRoute();
        endpoints.MapGet("/", async context => {
          await context.Response.WriteAsync("Hello World!");
        });
      });
    }

  }
}