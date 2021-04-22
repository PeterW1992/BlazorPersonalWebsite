using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using BlazorPersonalWebsite.Extensions;
using BlazorPersonalWebsite.Models.Interfaces;
using BlazorPersonalWebsite.Models;
using Microsoft.JSInterop;

namespace BlazorPersonalWebsite.Pages
{
    public partial class WoodworkProjectPage
    {
        [Inject]
        IJSRuntime JsRuntime { get; set; }

        [Inject]
        NavigationManager NavManager { get; set; }

        [Inject]
        IWoodworkProjectRepository WoodworkProjectRepo { get; set; }

        private WoodworkProject project;

        protected override async Task OnInitializedAsync()
        {
            var uri = NavManager.ToAbsoluteUri(NavManager.Uri);

            string projectRef;
            NavManager.TryGetQueryString<string>("projectRef", out projectRef);

            if (projectRef != null)
            {
                project = await WoodworkProjectRepo.GetWoodworkProjectAsync(projectRef);
            }

        }
    }
}
