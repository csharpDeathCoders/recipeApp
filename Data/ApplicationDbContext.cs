using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using recipeApp.Models;

namespace recipeApp.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
        public DbSet<ApplicationUser>? User { get; set; }
        public DbSet<DayPlan>? DayPlan { get; set; }
        public DbSet<Recipe>? Recipe { get; set; }
        public DbSet<WeekPlan>? WeekPlan { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
    {
        // seed data here
        base.OnModelCreating(builder);
    }

}
