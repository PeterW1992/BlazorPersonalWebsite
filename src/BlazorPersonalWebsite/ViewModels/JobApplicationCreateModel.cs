using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPersonalWebsite.ViewModels
{
    public class JobApplicationCreateModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DateAppliedFor { get; set; } = DateTime.Now;
    }
}
