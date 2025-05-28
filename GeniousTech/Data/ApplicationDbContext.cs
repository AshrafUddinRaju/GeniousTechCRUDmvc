using GeniousTech.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GeniousTech.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Service> Services { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }
    }
}
