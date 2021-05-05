using BlazorPersonalWebsite.Services;
using BlazorPersonalWebsite.ViewModels;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPersonalWebsite.Pages
{
    public partial class ListJobApplications
    {
        private IEnumerable<JobApplication> jobApplications;

        [Inject]
        IJobApplicationService JobApplicationService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            RefreshList();
        }

        public async void RefreshList()
        {
            jobApplications = await JobApplicationService.GetJobApplicationsAsync();
        }

        public async Task<bool> RemoveJobApplication(string applicationRef)
        {
            bool result = await JobApplicationService.RemoveJobApplicationAsync(applicationRef);
            RefreshList();
            return result;
        }
    }
}
