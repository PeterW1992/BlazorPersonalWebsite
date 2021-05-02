using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPersonalWebsite.EntityFramework
{
    public class WebsiteContextDesignTimeFactory : IDesignTimeDbContextFactory<WebsiteContext>
    {
        public WebsiteContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<WebsiteContext>();
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-UHG3KN8\\SQLEXPRESS;Initial Catalog=PersonalWebsite;Integrated Security=SSPI");

            return new WebsiteContext(optionsBuilder.Options);
        }
    }
}
