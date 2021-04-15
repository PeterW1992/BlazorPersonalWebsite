using BlazorPersonalWebsite.Models;
using BlazorPersonalWebsite.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace BlazorPersonalWebsite.DataAccess
{
    public class WoodworkProjectRepository : IWoodworkProjectRepository
    {
        public List<WoodworkProject> ListWoodworkProjects()
        {
            return new List<WoodworkProject>
            {
                new WoodworkProject
                {
                    Id = 1,
                    Name = "Side Gate",
                    DateCreated = DateTime.Parse("2017/07/05")
                },
                new WoodworkProject
                {
                    Id = 2,
                    Name = "Workbench",
                    DateCreated = DateTime.Parse("2017/08/21")
                },
                new WoodworkProject
                {
                    Id = 3,
                    Name = "Raised Garden bed (Pair)",
                    DateCreated = DateTime.Parse("2020/05/01")
                },
                new WoodworkProject
                {
                    Id = 4,
                    Name = "Raised Garden bed (Large)",
                    DateCreated = DateTime.Parse("2020/09/01")
                }
            };
        }
    }
}
