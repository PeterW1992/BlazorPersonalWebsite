using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using BlazorPersonalWebsite.Extensions;
using Microsoft.JSInterop;
using BlazorPersonalWebsite.Services;
using BlazorPersonalWebsite.ViewModels;
using System.Linq;

namespace BlazorPersonalWebsite.Pages
{
    public partial class EditSoftwareProjectPage
    {
        [Inject]
        IJSRuntime JsRuntime { get; set; }

        [Inject]
        NavigationManager NavManager { get; set; }

        [Inject]
        ISoftwareProjectService SoftwareProjectService { get; set; }

        private SoftwareProjectUpdateModel project;

        protected override async Task OnInitializedAsync()
        {
            var uri = NavManager.ToAbsoluteUri(NavManager.Uri);

            string projectRef;
            NavManager.TryGetQueryString<string>("projectRef", out projectRef);

            if (projectRef != null)
            {
                var softwareProject = await SoftwareProjectService.GetSoftwareProjectAsync(projectRef);

                project = new SoftwareProjectUpdateModel
                {
                    DateCreated = softwareProject.DateCreated,
                    Description = softwareProject.Description,
                    Images = softwareProject.Images.Select(img =>
                    new SoftwareProjectImageUpdateModel
                    {
                        ImageRef = img.ImageRef,
                        Description = img.Description,
                        ImageUrl = img.ImageUrl
                    }).ToList(),
                    Name = softwareProject.Name,
                    ProjectRef = softwareProject.ProjectRef
                };
            }

        }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await JsRuntime.InvokeAsync<object>("initializeCarousel");
            }
        }

        private async void UpdateSoftwareProject()
        {
            await SoftwareProjectService.UpdateSoftwareProjectAsync(project);
        }
    }
}
