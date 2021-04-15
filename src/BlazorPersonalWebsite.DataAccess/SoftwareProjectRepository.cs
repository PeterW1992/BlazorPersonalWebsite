using BlazorPersonalWebsite.Models;
using BlazorPersonalWebsite.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace BlazorPersonalWebsite.DataAccess
{
    public class SoftwareProjectRepository : ISoftwareProjectRepository
    {
        public List<SoftwareProject> ListSoftwareProjects()
        {
            return new List<SoftwareProject>
            {
                new SoftwareProject
                {
                    Id = 1,
                    Name = "Runescape Calculator",
                    DateCreated = DateTime.Parse("2013/01/01")
                },
                new SoftwareProject
                {
                    Id = 2,
                    Name = "University Project - E-Commere Project",
                    DateCreated = DateTime.Parse("2015/01/01")
                },
                new SoftwareProject
                {
                    Id = 3,
                    Name = "Loyalty Pro Android App",
                    DateCreated = DateTime.Parse("2016/10/01")

                },
                new SoftwareProject
                {
                    Id = 4,
                    Name = "University Dissertation - GPS Logger",
                    DateCreated = DateTime.Parse("2017/05/01")
                }
            };
        }
    }
}
