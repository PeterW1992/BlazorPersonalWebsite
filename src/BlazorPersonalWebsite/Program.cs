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

            var restApiConfig = new RestApiConfig
            {
                RestApiBaseUrl = builder.Configuration
                        .GetSection("RestApiConfig")
                        .GetSection("RestApiBaseUrl").Value
            };

            builder.Services
                .AddScoped(sp => new HttpClient { BaseAddress = new Uri(restApiConfig.RestApiBaseUrl) })
                .AddScoped(sp => restApiConfig)
                .AddScoped<IJobApplicationService, JobApplicationService>()
                .AddScoped<ISoftwareProjectService, SoftwareProjectService>()
                .AddScoped<IWoodworkProjectService, WoodworkProjectService>();

            await builder.Build().RunAsync();
        }
    }
}
