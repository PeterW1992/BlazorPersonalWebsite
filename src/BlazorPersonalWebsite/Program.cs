using BlazorPersonalWebsite.Config;
using BlazorPersonalWebsite.DataAccess;
using BlazorPersonalWebsite.EntityFramework;
using BlazorPersonalWebsite.Models.Interfaces;
using BlazorPersonalWebsite.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorPersonalWebsite
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.RootComponents.Add<App>("#app");

            builder.Services
                .AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost/RestApi/") })
                .AddScoped<IJobApplicationRepository, JobApplicationRepository>()
                .AddScoped<ISoftwareProjectService, SoftwareProjectService>()
                .AddScoped<IWoodworkProjectService, WoodworkProjectService>();

            await builder.Build().RunAsync();
        }
    }
}
