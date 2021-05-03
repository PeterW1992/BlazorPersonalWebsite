using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using BlazorPersonalWebsite.Extensions;
using BlazorPersonalWebsite.ViewModels;
using Microsoft.JSInterop;
using BlazorPersonalWebsite.Services;

namespace BlazorPersonalWebsite.Pages
{
    public partial class WoodworkProjectPage
    {
        [Inject]
        IJSRuntime JsRuntime { get; set; }

        [Inject]
        NavigationManager NavManager { get; set; }

        [Inject]
        IWoodworkProjectService WoodworkProjectService { get; set; }

        private WoodworkProject project;

        protected override async Task OnInitializedAsync()
        {
            var uri = NavManager.ToAbsoluteUri(NavManager.Uri);

            string projectRef;
            NavManager.TryGetQueryString<string>("projectRef", out projectRef);

            if (projectRef != null)
            {
                project = await WoodworkProjectService.GetWoodworkProjectAsync(projectRef);
            }

        }
    }
}
