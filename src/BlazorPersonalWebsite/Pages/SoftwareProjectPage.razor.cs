using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using BlazorPersonalWebsite.Extensions;
using Microsoft.JSInterop;
using BlazorPersonalWebsite.Services;
using BlazorPersonalWebsite.ViewModels;

namespace BlazorPersonalWebsite.Pages
{
    public partial class SoftwareProjectPage
    {
        [Inject]
        IJSRuntime JsRuntime { get; set; }

        [Inject]
        NavigationManager NavManager { get; set; }

        [Inject]
        ISoftwareProjectService SoftwareProjectService { get; set; }

        private SoftwareProject project;

        protected override async Task OnInitializedAsync()
        {
            var uri = NavManager.ToAbsoluteUri(NavManager.Uri);

            string projectRef;
            NavManager.TryGetQueryString<string>("projectRef", out projectRef);

            if (projectRef != null)
            {
                project = await SoftwareProjectService.GetSoftwareProjectAsync(projectRef);
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
