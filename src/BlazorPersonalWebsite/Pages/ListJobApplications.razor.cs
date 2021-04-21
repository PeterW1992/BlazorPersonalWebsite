using BlazorPersonalWebsite.Models.Interfaces;
using BlazorPersonalWebsite.ViewModels;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPersonalWebsite.Pages
{
    public partial class ListJobApplications
    {
        private List<JobApplication> jobApplications;

        [Inject]
        IJobApplicationRepository JobApplicationRepo { get; set; }

        protected override async Task OnInitializedAsync()
        {
            RefreshList();
        }

        public void RefreshList()
        {
            jobApplications = JobApplicationRepo
                .ListJobApplications()
                .Select(ja => new JobApplication
                {
                    JobApplicationRef = ja.JobApplicationRef,
                    DateAppliedFor = ja.DateApplied,
                    Description = ja.Description,
                    Title = ja.Title
                })
                .ToList();
        }

        public bool RemoveJobApplication(string applicationRef)
        {
            bool result = JobApplicationRepo.RemoveJobApplication(applicationRef);
            RefreshList();
            return result;
        }
    }
}
