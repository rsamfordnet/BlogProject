﻿using Microsoft.AspNetCore.Hosting;


[assembly: HostingStartup(typeof(BlogProject.Areas.Identity.IdentityHostingStartup))]

namespace BlogProject.Areas.Identity;

public class IdentityHostingStartup : IHostingStartup
{
    public void Configure(IWebHostBuilder builder)
    {
        builder.ConfigureServices((context, services) =>
        {
        });
    }
}