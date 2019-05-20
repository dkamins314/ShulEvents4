using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShulEvents4.ViewModels;

namespace ShulEvents4.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<ShulEvents4.ViewModels.CreateYearlyEventsViewModel> CreateYearlyEventsViewModel { get; set; }
    }
}
