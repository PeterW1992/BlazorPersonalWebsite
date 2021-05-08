using System;
using System.Collections.Generic;

namespace BlazorPersonalWebsite.ViewModels
{
    public class SoftwareProjectUpdateModel
    {
        public string ProjectRef { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime DateCreated { get; set; }

        public List<SoftwareProjectImageUpdateModel> Images { get; set; }
    }
}
