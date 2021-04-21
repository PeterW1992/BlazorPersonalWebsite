using BlazorPersonalWebsite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace BlazorPersonalWebsite.EntityFramework
{
    public class WebsiteContext : DbContext
    {

        public DbSet<JobApplication> JobApplications;

        public DbSet<SoftwareProject> SoftwareProjects;

        public DbSet<WoodworkProject> WoodworkProjects;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=PersonalWebsite;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JobApplication>()
                .HasKey(k => k.Id);

            modelBuilder.Entity<JobApplication>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<SoftwareProject>()
                .HasKey(k => k.Id);

            modelBuilder.Entity<SoftwareProject>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<WoodworkProject>()
                .HasKey(k => k.Id);

            modelBuilder.Entity<WoodworkProject>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Image>()
                .HasKey(k => k.ImageUrl);

            AddSoftwareProject(modelBuilder);
        }

        private void AddSoftwareProject(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SoftwareProject>()
                .HasData(
                new SoftwareProject
                {
                    Id = 1,
                    Name = "Runescape Calculator",
                    ProjectRef = "rsCalc",
                    Description = "Skill action calculator for video game Runescape",
                    DateCreated = DateTime.Parse("2013/01/01"),
                    Images = new List<Image>
                    {
                        new Image
                        {
                            ImageUrl = "images\\software-images\\rs-calculator\\1.png",
                            Description = "Agility skill calculator"
                        },
                        new Image
                        {
                            ImageUrl = "images\\software-images\\rs-calculator\\2.png",
                            Description = "Fishing skill calculator"
                        },
                        new Image
                        {
                            ImageUrl = "images\\software-images\\rs-calculator\\3.png",
                            Description = "Dropdown showing which skills are included"
                        },
                        new Image
                        {
                            ImageUrl = "images\\software-images\\rs-calculator\\4.png",
                            Description = "Dropdown showing skill subcategories"
                        }
                    }
                });
        }
    }
}
