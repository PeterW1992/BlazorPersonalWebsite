using System;
using System.Collections.Generic;

namespace BlazorPersonalWebsite.ViewModels
{
    public class WoodworkProject
    {
        public int Id { get; set; }

        public string ProjectRef { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime DateCreated { get; set; }

        public List<WoodworkProjectImage> Images { get; set; }
    }
}
