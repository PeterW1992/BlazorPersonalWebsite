using BlazorPersonalWebsite.DataAccess;
using BlazorPersonalWebsite.EntityFramework;
using BlazorPersonalWebsite.Models.Interfaces;
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

            string dbContext = "Server=(localdb)\\MSSQLLocalDB;Database=PersonalWebsite;Trusted_Connection=True;";

            builder.Services
                .AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) })
                .AddDbContext<WebsiteContext>(options => options.UseSqlServer(dbContext))
                .AddScoped<IJobApplicationRepository, JobApplicationRepository>()
                .AddScoped<ISoftwareProjectRepository, SoftwareProjectRepository>()
                .AddScoped<IWoodworkProjectRepository, WoodworkProjectRepository>();

            await builder.Build().RunAsync();
        }
    }
}
