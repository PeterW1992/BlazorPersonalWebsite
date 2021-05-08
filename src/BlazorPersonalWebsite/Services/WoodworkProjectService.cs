using BlazorPersonalWebsite.Config;
using BlazorPersonalWebsite.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorPersonalWebsite.Services
{
    public class WoodworkProjectService : IWoodworkProjectService
    {
        private readonly HttpClient _httpClient;

        public WoodworkProjectService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<IEnumerable<WoodworkProject>> GetWoodworkProjectsAsync()
        {
            var response = await _httpClient.GetAsync("woodworkProjects");

            string responseStr = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<WoodworkProject[]>(responseStr);
        }

        public async Task<WoodworkProject> GetWoodworkProjectAsync(string projectRef)
        {
            var response = await _httpClient.GetAsync($"woodworkProjects/{projectRef}");

            string responseStr = await response.Content.ReadAsStringAsync();

            WoodworkProject[] projects = JsonConvert.DeserializeObject<WoodworkProject[]>(responseStr);

            return projects.First();
        }
    }
}
