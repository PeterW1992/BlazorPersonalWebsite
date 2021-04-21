using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using BlazorPersonalWebsite.Extensions;
using BlazorPersonalWebsite.Models.Interfaces;
using BlazorPersonalWebsite.Models;
using Microsoft.JSInterop;

namespace BlazorPersonalWebsite.Pages
{
    public partial class SoftwareProjectPage
    {
        [Inject]
        IJSRuntime JsRuntime { get; set; }

        [Inject]
        NavigationManager NavManager { get; set; }

        [Inject]
        ISoftwareProjectRepository SoftwareProjectRepo { get; set; }

        private SoftwareProject project;

        protected override async Task OnInitializedAsync()
        {
            var uri = NavManager.ToAbsoluteUri(NavManager.Uri);

            string projectRef;
            NavManager.TryGetQueryString<string>("projectRef", out projectRef);

            if (projectRef != null)
            {
                project = SoftwareProjectRepo.GetSoftwareProject(projectRef);
            }

        }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await JsRuntime.InvokeAsync<object>("initializeCarousel");
            }
        }

    }
}
