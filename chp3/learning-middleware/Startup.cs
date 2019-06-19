using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace learning_middleware
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            /* The will product the error message but without page layout */
            //app.UseStatusCodePages("text/html", "<h3>Page Not Found: {0}</h3>");

            /* This will issues a 302 and redirect will occur on the client side */
            //app.UseStatusCodePagesWithRedirects("/{0}.html");

            /* The redirect will occur but only on the server */
            app.UseStatusCodePagesWithReExecute("/{0}.html");
            
            /*
             * The StatusCodePages Middlewares are for client side errors.
             * Server side error are handled by DeveloperExceptionPage and ExceptionHandler middleware
             */
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/error/error");
            }

            /* Middleware 2: WelcomePageMiddleware */
            //app.UseWelcomePage();
            
            /* Middleware 3: StaticFileMiddleware */
            app.UseStaticFiles();

           

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}"
                );
            });
            
        }
    }
}
