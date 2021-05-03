using BlazorPersonalWebsite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace BlazorPersonalWebsite.EntityFramework
{
    public class WebsiteContext : DbContext
    {
        public DbSet<JobApplication> JobApplications { get; set; }

        public DbSet<SoftwareProject> SoftwareProjects { get; set; }

        public DbSet<WoodworkProject> WoodworkProjects { get; set; }

        public WebsiteContext(DbContextOptions<WebsiteContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JobApplication>()
               .ToTable("JobApplication");

            modelBuilder.Entity<JobApplication>()
                .HasKey(k => k.Id);

            modelBuilder.Entity<JobApplication>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<SoftwareProject>()
                .ToTable("SoftwareProject");

            modelBuilder.Entity<SoftwareProject>()
                .HasKey(k => k.Id);

            modelBuilder.Entity<SoftwareProject>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<WoodworkProject>()
                .ToTable("WoodworkProject");

            modelBuilder.Entity<WoodworkProject>()
                .HasKey(k => k.Id);

            modelBuilder.Entity<WoodworkProject>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<SoftwareProjectImage>()
               .ToTable("SoftwareProjectImage");

            modelBuilder.Entity<SoftwareProjectImage>()
                .HasKey(k => k.ImageUrl);

            modelBuilder.Entity<SoftwareProjectImage>()
                .Property(x => x.SoftwareProjectImageId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<WoodworkProjectImage>()
               .ToTable("WoodworkProjectImage");

            modelBuilder.Entity<WoodworkProjectImage>()
                .Property(x => x.WoodworkProjectImageId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<WoodworkProjectImage>()
                .HasKey(k => k.ImageUrl);

            AddSoftwareProjects(modelBuilder);
            //AddWoodworkProjects(modelBuilder);
        }

        private void AddWoodworkProjects(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WoodworkProjectImage>()
                .HasData(
                new WoodworkProject
                {
                    Id = 1,
                    Name = "Side Gate",
                    ProjectRef = "sideGate",
                    DateCreated = DateTime.Parse("2017/07/05"),
                    Images = new List<WoodworkProjectImage>
                    {
                        new WoodworkProjectImage
                        {
                            Description = "Unhung gate",
                            ImageUrl = "images\\woodwork-images\\side-gate\\sidegate-unhung.jpg"
                        }
                    }
                },
                new WoodworkProject
                {
                    Id = 2,
                    Name = "Workbench",
                    ProjectRef = "workbench",
                    DateCreated = DateTime.Parse("2017/08/21"),
                    Images = new List<WoodworkProjectImage>
                    {
                        new WoodworkProjectImage
                        {
                            Description = "Unfinished workbench",
                            ImageUrl = "images\\woodwork-images\\workbench\\workbench-unfinished.jpg"
                        }
                    }
                },
                 new WoodworkProject
                 {
                     Id = 3,
                     Name = "Bird table",
                     ProjectRef = "birdTable",
                     DateCreated = DateTime.Parse("2017/08/21"),
                     Images = new List<WoodworkProjectImage>
                    {
                        new WoodworkProjectImage
                        {
                            Description = "Unfinished workbench",
                            ImageUrl = "images\\woodwork-images\\bird-table\\bird-table.jpg"
                        }
                    }
                 },
                new WoodworkProject
                {
                    Id = 5,
                    Name = "Raised Garden bed (Small)",
                    ProjectRef = "raisedGardenBendSmall",
                    DateCreated = DateTime.Parse("2020/05/01"),
                    //Images = new List<Image>
                    //{
                    //    new Image
                    //    {
                    //        Description = "Unhung gate",
                    //        ImageUrl = "images\\project-images\\side-gate\\sidegate-unhung.jpg"
                    //    }
                    //}
                },
                new WoodworkProject
                {
                    Id = 6,
                    Name = "Raised Garden bed (Large)",
                    ProjectRef = "raisedGardenBendLarge",
                    DateCreated = DateTime.Parse("2020/09/01"),
                    //Images = new List<Image>
                    //{
                    //    new Image
                    //    {
                    //        Description = "Unhung gate",
                    //        ImageUrl = "images\\project-images\\side-gate\\sidegate-unhung.jpg"
                    //    }
                    //}
                });
        }

        private void AddSoftwareProjects(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SoftwareProjectImage>()
                .HasData(
                    new SoftwareProjectImage
                    {
                        ImageUrl = "images\\software-images\\rs-calculator\\1.png",
                        Description = "Agility skill calculator",
                        SoftwareProjectId = 1
                    },
                    new SoftwareProjectImage
                    {
                        ImageUrl = "images\\software-images\\rs-calculator\\2.png",
                        Description = "Fishing skill calculator",
                        SoftwareProjectId = 1
                    },
                    new SoftwareProjectImage
                    {
                        ImageUrl = "images\\software-images\\rs-calculator\\3.png",
                        Description = "Dropdown showing which skills are included",
                        SoftwareProjectId = 1
                    },
                    new SoftwareProjectImage
                    {
                        ImageUrl = "images\\software-images\\rs-calculator\\4.png",
                        Description = "Dropdown showing skill subcategories",
                        SoftwareProjectId = 1
                    }
                );

            modelBuilder.Entity<SoftwareProject>()
                .HasData(
                    new SoftwareProject
                    {
                        Id = 1,
                        Name = "Runescape Calculator",
                        ProjectRef = "rsCalc",
                        Description = "Skill action calculator for video game Runescape",
                        DateCreated = DateTime.Parse("2013/01/01"),
                    }
            //new SoftwareProject
            //{
            //    Id = 2,
            //    Name = "University Project - E-Commere Project",
            //    ProjectRef = "uniEcom",
            //    DateCreated = DateTime.Parse("2015/01/01"),
            //    Images = new List<SoftwareProjectImage>
            //    {
            //        new SoftwareProjectImage
            //        {
            //            ImageUrl = "images\\software-images\\ecommerce-site\\1.png",
            //        },
            //        new SoftwareProjectImage
            //        {
            //            ImageUrl = "images\\software-images\\ecommerce-site\\2.png",
            //        },
            //        new SoftwareProjectImage
            //        {
            //            ImageUrl = "images\\software-images\\ecommerce-site\\3.png",
            //        },
            //        new SoftwareProjectImage
            //        {
            //            ImageUrl = "images\\software-images\\ecommerce-site\\4.png",
            //        },
            //        new SoftwareProjectImage
            //        {
            //            ImageUrl = "images\\software-images\\ecommerce-site\\5.png",
            //        },
            //        new SoftwareProjectImage
            //        {
            //            ImageUrl = "images\\software-images\\ecommerce-site\\6.png",
            //        },
            //    }
            //},
            //new SoftwareProject
            //{
            //    Id = 3,
            //    Name = "Loyalty Pro Android App",
            //    ProjectRef = "loyaltyProApp",
            //    DateCreated = DateTime.Parse("2016/10/01"),
            //    Images = new List<SoftwareProjectImage>
            //    {
            //         new SoftwareProjectImage
            //        {
            //            ImageUrl = "images\\software-images\\loyalty-pro-app\\1.png"
            //        },
            //          new SoftwareProjectImage
            //        {
            //            ImageUrl = "images\\software-images\\loyalty-pro-app\\2.png"
            //        },
            //           new SoftwareProjectImage
            //        {
            //            ImageUrl = "images\\software-images\\loyalty-pro-app\\3.png"
            //        },
            //        new SoftwareProjectImage
            //        {
            //            ImageUrl = "images\\software-images\\loyalty-pro-app\\4.png"
            //        },
            //        new SoftwareProjectImage
            //        {
            //            ImageUrl = "images\\software-images\\loyalty-pro-app\\5.png"
            //        },
            //        new SoftwareProjectImage
            //        {
            //            ImageUrl = "images\\software-images\\loyalty-pro-app\\6.png"
            //        }
            //    }
            //},
            //new SoftwareProject
            //{
            //    Id = 4,
            //    Name = "University Dissertation - GPS Logger",
            //    ProjectRef = "uniDis",
            //    DateCreated = DateTime.Parse("2017/05/01"),
            //    Images = new List<SoftwareProjectImage>
            //    {
            //        new SoftwareProjectImage
            //        {
            //            ImageUrl = "images\\software-images\\gps-logger\\1.png",
            //        },
            //        new SoftwareProjectImage
            //        {
            //            ImageUrl = "images\\software-images\\gps-logger\\2.png",
            //        },
            //        new SoftwareProjectImage
            //        {
            //            ImageUrl = "images\\software-images\\gps-logger\\3.png",
            //        },
            //        new SoftwareProjectImage
            //        {
            //            ImageUrl = "images\\software-images\\gps-logger\\4.png",
            //        },
            //        new SoftwareProjectImage
            //        {
            //            ImageUrl = "images\\software-images\\gps-logger\\5.png",
            //        }
            //    }

            //}
            );
        }
    }
}
