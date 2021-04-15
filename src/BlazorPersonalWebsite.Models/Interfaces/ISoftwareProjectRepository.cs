using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorPersonalWebsite.Models.Interfaces
{
    public interface ISoftwareProjectRepository
    {
        public List<SoftwareProject> ListSoftwareProjects();
    }
}
