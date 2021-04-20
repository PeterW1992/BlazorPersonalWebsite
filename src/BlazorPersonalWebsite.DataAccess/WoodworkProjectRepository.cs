using BlazorPersonalWebsite.Models;
using BlazorPersonalWebsite.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace BlazorPersonalWebsite.DataAccess
{
    public class WoodworkProjectRepository : IWoodworkProjectRepository
    {
        private List<WoodworkProject> _woodworkProjects = new List<WoodworkProject>
            {
                new WoodworkProject
                {
                    Id = 1,
                    Name = "Side Gate",
                    ProjectRef = "sideGate",
                    DateCreated = DateTime.Parse("2017/07/05"),
                    Images = new List<Image>
                    {
                        new Image
                        {
                            Description = "Unhung gate",
                            ImageUrl = ".\\images\\woodwork-images\\side-gate\\sidegate-unhung.png"
                        }
                    }
                },
                new WoodworkProject
                {
                    Id = 2,
                    Name = "Workbench",
                    ProjectRef = "workbench",
                    DateCreated = DateTime.Parse("2017/08/21"),
                    Images = new List<Image>
                    {
                        new Image
                        {
                            Description = "Unfinished workbench",
                            ImageUrl = ".\\images\\woodwork-images\\workbench\\workbench-unfinished.png"
                        }
                    }
                },
                 new WoodworkProject
                {
                    Id = 3,
                    Name = "Bird table",
                    ProjectRef = "birdTable",
                    DateCreated = DateTime.Parse("2017/08/21"),
                    Images = new List<Image>
                    {
                        new Image
                        {
                            Description = "Unfinished workbench",
                            ImageUrl = ".\\images\\woodwork-images\\bird-table\\bird-table.png"
                        }
                    }
                },
                new WoodworkProject
                {
                    Id = 5,
                    Name = "Raised Garden bed (Small)",
                    ProjectRef = "raisedGardenBendSmall",
                    DateCreated = DateTime.Parse("2020/05/01"),
                    Images = new List<Image>
                    {
                        new Image
                        {
                            Description = "Unhung gate",
                            ImageUrl = ".\\images\\project-images\\side-gate\\sidegate-unhung.png"
                        }
                    }
                },
                new WoodworkProject
                {
                    Id = 6,
                    Name = "Raised Garden bed (Large)",
                    ProjectRef = "raisedGardenBendLarge",
                    DateCreated = DateTime.Parse("2020/09/01"),
                    Images = new List<Image>
                    {
                        new Image
                        {
                            Description = "Unhung gate",
                            ImageUrl = ".\\images\\project-images\\side-gate\\sidegate-unhung.png"
                        }
                    }
                }
            };

        public WoodworkProject GetWoodworkProjects(string projectRef)
        {
            return this._woodworkProjects.Find(s => s.ProjectRef == projectRef);
        }

        public List<WoodworkProject> ListWoodworkProjects()
        {
            return _woodworkProjects;
        }
    }
}
