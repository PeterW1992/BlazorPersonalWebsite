using BlazorPersonalWebsite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPersonalWebsite.Services
{
    public interface IWoodworkProjectService
    {
        Task<IEnumerable<WoodworkProject>> GetWoodworkProjectsAsync();

        Task<WoodworkProject> GetWoodworkProjectAsync(string projectRef);
    }
}
