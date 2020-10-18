using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CoreTest
{
    public class Startup
    {
        public int[] cap;
        private readonly IConfiguration _Config;

        public Startup(IConfiguration config)
        {//Test // 1234567811231234242413

            //123
            //456
            _Config = config;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        //­t³d ¨Ì¿àª`¤JDI
        public void ConfigureServices(IServiceCollection services)
        {
            Dictionary<string,int> DIC = new Dictionary<string, int>();
            //services.AddMvc(); BIG  MVC
            //services.AddControllersWithViews();  ¨Ï¥ÎMVC
            //services.AddSingleton()
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            //app.Use;

            app.UseEndpoints(endpoints =>{endpoints.MapGet("/", async context =>
                {
                    var TestStr = _Config["TestKey"];
                    var Pname = System.Diagnostics.Process.GetCurrentProcess().ProcessName; //Get Process Name 
                    await context.Response.WriteAsync(TestStr);
                });
            });
        }
    }
}
