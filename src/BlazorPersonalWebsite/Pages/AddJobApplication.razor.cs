using BlazorPersonalWebsite.Models;
using BlazorPersonalWebsite.Models.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPersonalWebsite.Pages
{
    public partial class AddJobApplication
    {
        [Inject]
        IJSRuntime JsRuntime { get; set; }

        [Inject]
        NavigationManager NavManager { get; set; }

        [Inject]
        IJobApplicationRepository JobApplicationRepo { get; set; }

        [Parameter] public EventCallback<string> OnAdd { get; set; }


        public ViewModels.JobApplicationCreateModel jobApplication = new ViewModels.JobApplicationCreateModel();

        public void AddNewJobApplication()
        {
            JobApplicationRepo.AddJobApplication(
                new Models.JobApplicationCreateModel
                {
                    JobApplicationRef = Guid.NewGuid().ToString(),
                    AppliedDateTime = jobApplication.DateAppliedFor,
                    Description = jobApplication.Description,
                    Title = jobApplication.Title,
                }); 

            OnAdd.InvokeAsync();
        }
    }
}
