using BlazorPersonalWebsite.EntityFramework;
using BlazorPersonalWebsite.Models;
using BlazorPersonalWebsite.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPersonalWebsite.DataAccess
{
    public class WoodworkProjectRepository : IWoodworkProjectRepository
    {
        //private List<WoodworkProject> _woodworkProjects = new List<WoodworkProject>
        //    {
        //        new WoodworkProject
        //        {
        //            Id = 1,
        //            Name = "Side Gate",
        //            ProjectRef = "sideGate",
        //            DateCreated = DateTime.Parse("2017/07/05"),
        //            Images = new List<Image>
        //            {
        //                new Image
        //                {
        //                    Description = "Unhung gate",
        //                    ImageUrl = "images\\woodwork-images\\side-gate\\sidegate-unhung.jpg"
        //                }
        //            }
        //        },
        //        new WoodworkProject
        //        {
        //            Id = 2,
        //            Name = "Workbench",
        //            ProjectRef = "workbench",
        //            DateCreated = DateTime.Parse("2017/08/21"),
        //            Images = new List<Image>
        //            {
        //                new Image
        //                {
        //                    Description = "Unfinished workbench",
        //                    ImageUrl = "images\\woodwork-images\\workbench\\workbench-unfinished.jpg"
        //                }
        //            }
        //        },
        //         new WoodworkProject
        //        {
        //            Id = 3,
        //            Name = "Bird table",
        //            ProjectRef = "birdTable",
        //            DateCreated = DateTime.Parse("2017/08/21"),
        //            Images = new List<Image>
        //            {
        //                new Image
        //                {
        //                    Description = "Unfinished workbench",
        //                    ImageUrl = "images\\woodwork-images\\bird-table\\bird-table.jpg"
        //                }
        //            }
        //        },
        //        new WoodworkProject
        //        {
        //            Id = 5,
        //            Name = "Raised Garden bed (Small)",
        //            ProjectRef = "raisedGardenBendSmall",
        //            DateCreated = DateTime.Parse("2020/05/01"),
        //            //Images = new List<Image>
        //            //{
        //            //    new Image
        //            //    {
        //            //        Description = "Unhung gate",
        //            //        ImageUrl = "images\\project-images\\side-gate\\sidegate-unhung.jpg"
        //            //    }
        //            //}
        //        },
        //        new WoodworkProject
        //        {
        //            Id = 6,
        //            Name = "Raised Garden bed (Large)",
        //            ProjectRef = "raisedGardenBendLarge",
        //            DateCreated = DateTime.Parse("2020/09/01"),
        //            //Images = new List<Image>
        //            //{
        //            //    new Image
        //            //    {
        //            //        Description = "Unhung gate",
        //            //        ImageUrl = "images\\project-images\\side-gate\\sidegate-unhung.jpg"
        //            //    }
        //            //}
        //        }
        //};

        private readonly WebsiteContext _dbContext;

        public WoodworkProjectRepository(WebsiteContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<WoodworkProject> GetWoodworkProjectAsync(string projectRef)
        {
            return await this._dbContext.WoodworkProjects.AsNoTracking().SingleOrDefaultAsync(s => s.ProjectRef == projectRef);
        }

        public async Task<List<WoodworkProject>>ListWoodworkProjectsAsync()
        {
            return await this._dbContext.WoodworkProjects.AsNoTracking().ToListAsync();
        }
    }
}
