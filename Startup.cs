//using BlogProject.Data;
//using BlogProject.Helpers;
//using BlogProject.Models;
//using BlogProject.Services;
//using BlogProject.ViewModels;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.HttpsPolicy;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.UI;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Hosting;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using TheBlogProject.Services;
//using Microsoft.AspNetCore.Identity.UI.Services;

//namespace BlogProject;

//public class Startup
//{
//    public Startup(IConfiguration configuration)
//    {
//        Configuration = configuration;
//    }

//    public IConfiguration Configuration { get; }
 

    // This method gets called by the runtime. Use this method to add services to the container.
    //public void ConfigureServices(IServiceCollection services)
    //{
      //  services.AddDbContext<ApplicationDbContext>(options =>
       //     options.UseSqlServer(
      //          Configuration.GetConnectionString("DefaultConnection")));

        //services.AddDbContext<ApplicationDbContext>(options =>
        //    options.UseNpgsql(
        //        Configuration.GetConnectionString("DefaultConnection")));

        //services.AddDatabaseDeveloperPageExceptionFilter();

       //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
       //     .AddEntityFrameworkStores<ApplicationDbContext>();

        //services.AddIdentity<BlogUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
        //    .AddDefaultUI()
        //    .AddDefaultTokenProviders()
        //    .AddEntityFrameworkStores<ApplicationDbContext>();
        //services.AddControllersWithViews();
        //services.AddRazorPages();

        //Register my custom DataService class
        //services.AddScoped<DataService>();
        //services.AddScoped<BlogSearchService>();

        //Register a preconfigured instance of the MailSettings class
        //services.Configure<MailSettings>(Configuration.GetSection("MailSettings"));
        //services.AddScoped<IBlogEmailSender, EmailService>();

        //Register our Image Service
        //services.AddScoped<IImageService, BasicImageService>();

        //Register the Slug Service
        //services.AddScoped<ISlugService, BasicSlugService>();



    //}

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    //public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    //{
    //    if (env.IsDevelopment())
    //    {
    //        app.UseExceptionHandler("/Home/Error");
            //app.UseDeveloperExceptionPage();
            //app.UseMigrationsEndPoint();
        //    app.UseHsts();
        //}
        //else
        //{
        //    app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        //    app.UseHsts();
        //}
        //app.UseHttpsRedirection();
        //app.UseStaticFiles();
        //app.UseRouting();

        //app.UseEndpoints(endpoints =>
        //{
        //    endpoints.MapRazorPages();
        //});
        //app.UseRouting();

        //app.UseAuthentication();
        //app.UseAuthorization();

        //app.UseEndpoints(endpoints =>
        //{
        //    endpoints.MapControllerRoute(
        //        name: "SlugRoute",
        //        pattern: "BlogPosts/UrlFriendly/{slug}",
        //        defaults: new { controller = "Posts", action = "Details" });


        //    endpoints.MapControllerRoute(
        //        name: "default",
        //        pattern: "{controller=Posts}/{action=BlogPostIndex}/{id?}");





        //    endpoints.MapRazorPages();
        //});
//    }
//}
