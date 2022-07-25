using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PortfolioApp.Models;
using PortfolioApp.ViewModels;

namespace PortfolioApp.Data
{
    //the inherited IdentityDbContext with generic type <user>  enjoys the attributes of the identity
    //hence no need for dbset for user
    public class PortfolioAppContext : IdentityDbContext<User>
    {
        public PortfolioAppContext(DbContextOptions<PortfolioAppContext> options): base(options)
        {
        }
        // naming convention ends with "s"
        //public DbSet<User> MyUsers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        public DbSet<PortfolioApp.ViewModels.ProjectListViewModel> ProjectListViewModel { get; set; }
        public DbSet<PortfolioApp.ViewModels.SkillListViewModel> SkillListViewModel { get; set; }
    }
}
//next create migration