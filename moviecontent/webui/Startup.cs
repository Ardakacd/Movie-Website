using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using data.Concrete;
using data.Abstract;
using webui.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using webui.EmailService;
using Microsoft.Extensions.Configuration;

namespace moviecontent
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        private IConfiguration configuration;

        public Startup(IConfiguration configuration){
            this.configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<IdentityContext>(options => options.UseMySQL(@"server=localhost;port=3306;database=users;user=root;password=arda1602"));
            services.AddIdentity<User,IdentityRole>().AddErrorDescriber<LocalizedIdentityErrorDescriber>().AddEntityFrameworkStores<IdentityContext>().AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>{

                options.Password.RequireUppercase=false;
                options.Password.RequireNonAlphanumeric = false;
                
                options.SignIn.RequireConfirmedEmail = true;
                options.SignIn.RequireConfirmedPhoneNumber = false;
                options.User.RequireUniqueEmail = true;
                options.Lockout.AllowedForNewUsers = true;
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                

            });

            services.ConfigureApplicationCookie(options => {
                options.LoginPath = "/manager/login";
                options.LogoutPath = "/manager/logout";
                options.AccessDeniedPath = "/manager/access-denied";
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
                options.Cookie = new CookieBuilder(){
                    HttpOnly = true,
                    Name = "MovieApp-Security-Cookie"
                    
                };
            });

            
            services.AddControllersWithViews();
            services.AddScoped<ICategoryRepository,CategoryRepository>();
            services.AddScoped<IPlayerRepository,PlayerRepository>();
            services.AddScoped<IMovieRepository,MovieRepository>();
            services.AddScoped<IDirectorRepository,DirectorRepository>();
            services.AddScoped<IEmailSender,SmtpEmailSender>(i =>
            new SmtpEmailSender(
                configuration["EmailSender:Host"],
                configuration.GetValue<int>("EmailSender:Port"),
                configuration["EmailSender:User"],
                configuration["EmailSender:Password"],
                configuration.GetValue<bool>("EmailSender:EnableSsl"))


            );
            
        }
        

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                SeedData.seed();
                app.UseDeveloperExceptionPage();

                

            }

            app.UseRouting();
            app.UseAuthentication();
              
            

            app.UseStaticFiles();
            app.UseAuthorization();

            

            app.UseEndpoints(endpoints =>
            {


                endpoints.MapControllerRoute(
                    name:"home",
                    pattern:"home",
                    defaults: new {Controller = "Home", Action="Main"}
                );

                  endpoints.MapControllerRoute(
                    name:"movie",
                    pattern:"movies",
                    defaults: new {Controller = "Movie", Action="list"}
                );

                 endpoints.MapControllerRoute(
                    name:"player",
                    pattern:"players",
                    defaults: new {Controller = "Player", Action="list"}
                );

                endpoints.MapControllerRoute(
                    name:"director",
                    pattern:"directors",
                    defaults: new {Controller = "Director", Action="list"}
                );

                 endpoints.MapControllerRoute(
                    name:"category",
                    pattern:"categories/{id}",
                    defaults: new {Controller = "Category", Action="wanted"}
                );

                  endpoints.MapControllerRoute(
                    name:"moviedetail",
                    pattern:"movie-detail/{id}",
                    defaults: new {Controller = "Movie", Action="detail"}
                );

                endpoints.MapControllerRoute(
                    name:"playerdetail",
                    pattern:"player-detail/{id}",
                    defaults: new {Controller = "Player", Action="detail"}
                );

                 endpoints.MapControllerRoute(
                    name:"directordetail",
                    pattern:"director-detail/{id}",
                    defaults: new {Controller = "Director", Action="detail"}
                );

                 endpoints.MapControllerRoute(
                    name:"search",
                    pattern:"search",
                    defaults: new {Controller = "Search", Action="index"}
                );

                  endpoints.MapControllerRoute(
                    name:"access-denied",
                    pattern:"/manager/access-denied",
                    defaults: new {Controller = "Manager", Action="AccessDenied"}
                );


                endpoints.MapControllerRoute(
                    name:"default",
                    pattern:"{controller=Manager}/{action=Register}/{id?}"
                );
                
            });
        }
    }
}
