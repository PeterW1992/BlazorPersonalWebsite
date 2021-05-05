using BlazorPersonalWebsite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPersonalWebsite.Services
{
    public interface IJobApplicationService
    {
        Task<JobApplication> AddJobApplicationAsync(JobApplicationCreateModel createModel);

        Task<IEnumerable<JobApplication>> GetJobApplicationsAsync();

        Task<JobApplication> GetJobApplicationAsync(string projectRef);

        Task<bool> RemoveJobApplicationAsync(string projectRef);
    }
}
