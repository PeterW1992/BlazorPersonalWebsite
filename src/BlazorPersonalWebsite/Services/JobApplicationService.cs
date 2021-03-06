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
    public class JobApplicationService : IJobApplicationService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiBaseUrl;

        public JobApplicationService(HttpClient httpClient, RestApiConfig restApiConfig)
        {
            this._httpClient = httpClient;
            this._apiBaseUrl = restApiConfig.RestApiBaseUrl;
        }
        public Task<JobApplication> AddJobApplicationAsync(JobApplicationCreateModel createModel)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<JobApplication>> GetJobApplicationsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<JobApplication> GetJobApplicationAsync(string projectRef)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveJobApplicationAsync(string projectRef)
        {
            throw new NotImplementedException();
        }
    }
}
