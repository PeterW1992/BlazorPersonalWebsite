using BlazorPersonalWebsite.Config;
using BlazorPersonalWebsite.Services;
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
                .AddScoped(sp => new HttpClient())
                .AddScoped(sp => new RestApiConfig
                {
                    RestApiBaseUrl = builder.Configuration
                        .GetSection("RestApiConfig")
                        .GetSection("RestApiBaseUrl").Value
                })
                .AddScoped<IJobApplicationService, JobApplicationService>()
                .AddScoped<ISoftwareProjectService, SoftwareProjectService>()
                .AddScoped<IWoodworkProjectService, WoodworkProjectService>();

            await builder.Build().RunAsync();
        }
    }
}
