using BlazorPersonalWebsite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPersonalWebsite.Services
{
    public interface ISoftwareProjectService
    {
        Task<IEnumerable<SoftwareProject>> GetSoftwareProjectsAsync();

        Task<SoftwareProject> GetSoftwareProjectAsync(string projectRef);
    }
}
