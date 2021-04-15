using BlazorPersonalWebsite.DataAccess;
using BlazorPersonalWebsite.Models.Interfaces;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
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
                .AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) })
                .AddSingleton<ISoftwareProjectRepository, SoftwareProjectRepository>()
                .AddSingleton<IWoodworkProjectRepository, WoodworkProjectRepository>();

            await builder.Build().RunAsync();
        }
    }
}
