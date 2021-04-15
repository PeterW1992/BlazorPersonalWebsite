using BlazorPersonalWebsite.Models;
using BlazorPersonalWebsite.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace BlazorPersonalWebsite.DataAccess
{
    public class SoftwareProjectRepository : ISoftwareProjectRepository
    {
        private List<SoftwareProject> _softwareProjects = new List<SoftwareProject>
            {
                new SoftwareProject
                {
                    Id = 1,
                    Name = "Runescape Calculator",
                    ProjectRef ="rsCalc",
                    DateCreated = DateTime.Parse("2013/01/01"),
                    Images = new List<string>
                    {
                        ".\\images\\software-images\\rs-calculator\\1.png",
                        ".\\images\\software-images\\rs-calculator\\2.png",
                        ".\\images\\software-images\\rs-calculator\\3.png",
                        ".\\images\\software-images\\rs-calculator\\4.png",
                    }
                },
                new SoftwareProject
                {
                    Id = 2,
                    Name = "University Project - E-Commere Project",
                    ProjectRef ="uniEcom",
                    DateCreated = DateTime.Parse("2015/01/01"),
                    Images = new List<string>
                    {
                        ".\\images\\software-images\\ecommerce-site\\1.png",
                        ".\\images\\software-images\\ecommerce-site\\2.png",
                        ".\\images\\software-images\\ecommerce-site\\3.png",
                        ".\\images\\software-images\\ecommerce-site\\4.png",
                        ".\\images\\software-images\\ecommerce-site\\5.png",
                        ".\\images\\software-images\\ecommerce-site\\6.png",
                    }
                },
                new SoftwareProject
                {
                    Id = 3,
                    Name = "Loyalty Pro Android App",
                    ProjectRef ="loyaltyProApp",
                    DateCreated = DateTime.Parse("2016/10/01"),
                    Images = new List<string>
                    {
                        ".\\images\\software-images\\loyalty-pro-app\\1.png",
                        ".\\images\\software-images\\loyalty-pro-app\\2.png",
                        ".\\images\\software-images\\loyalty-pro-app\\3.png",
                        ".\\images\\software-images\\loyalty-pro-app\\4.png",
                        ".\\images\\software-images\\loyalty-pro-app\\5.png",
                        ".\\images\\software-images\\loyalty-pro-app\\6.png",
                    }
                },
                new SoftwareProject
                {
                    Id = 4,
                    Name = "University Dissertation - GPS Logger",
                    ProjectRef ="uniDis",
                    DateCreated = DateTime.Parse("2017/05/01"),
                    Images = new List<string>
                    {
                        ".\\images\\software-images\\gps-logger\\1.png",
                        ".\\images\\software-images\\gps-logger\\2.png",
                        ".\\images\\software-images\\gps-logger\\3.png",
                        ".\\images\\software-images\\gps-logger\\4.png",
                        ".\\images\\software-images\\gps-logger\\5.png",
                    }
                }
            };

        public SoftwareProject GetSoftwareProject(string projectRef)
        {
            return this._softwareProjects.Find(s => s.ProjectRef == projectRef);
        }

        public List<SoftwareProject> ListSoftwareProjects()
        {
            return _softwareProjects;
        }
    }
}
