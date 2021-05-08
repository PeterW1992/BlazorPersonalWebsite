using BlazorPersonalWebsite.Config;
using BlazorPersonalWebsite.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPersonalWebsite.Services
{
    public class SoftwareProjectService : ISoftwareProjectService
    {
        private readonly HttpClient _httpClient;

        public SoftwareProjectService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<IEnumerable<SoftwareProject>> GetSoftwareProjectsAsync()
        {
            var response = await _httpClient.GetAsync("softwareProjects");

            string responseStr = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<SoftwareProject[]>(responseStr);
        }

        public async Task<SoftwareProject> GetSoftwareProjectAsync(string projectRef)
        {
            var response = await _httpClient.GetAsync($"softwareProjects/{projectRef}");

            string responseStr = await response.Content.ReadAsStringAsync();

            SoftwareProject[] projects = JsonConvert.DeserializeObject<SoftwareProject[]>(responseStr);

            return projects.First();
        }

        public async Task<SoftwareProject> UpdateSoftwareProjectAsync(SoftwareProjectUpdateModel updateModel)
        {
            var content = new StringContent(JsonConvert.SerializeObject(updateModel), Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync($"softwareProjects/{updateModel.ProjectRef}", content);

            string responseStr = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<SoftwareProject>(responseStr);
        }
    }
}
