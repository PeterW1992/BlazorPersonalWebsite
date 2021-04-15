using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorPersonalWebsite.Models.Interfaces
{
    public interface IWoodworkProjectRepository
    {
        public List<WoodworkProject> ListWoodworkProjects();
    }
}
