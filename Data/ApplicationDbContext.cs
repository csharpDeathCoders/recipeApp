using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RecipeApp.Models;

namespace RecipeApp.Data
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<WeekPlan>? WeekPlans { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
    //     protected override void OnModelCreating(ModelBuilder builder)
    //     {
    //         base.OnModelCreating(builder);

    //         //a hasher to hash the password before seeding the user to the db
    //         var hasher = new PasswordHasher<IdentityUser>();

    //         //Seeding the User to AspNetUsers table
    //         builder.Entity<IdentityUser>().HasData(
    //             new IdentityUser
    //             {
    //                 Id = "8e445865-a24d-4543-a6c6-9443d048cdb9", // primary key
    //                 UserName = "myuser",
    //                 NormalizedUserName = "MYUSER",
    //                 PasswordHash = hasher.HashPassword(null, "Pa$$w0rd")
    //             }
    //         );

    //         //making a dayplan
    //         DayPlan dayplan = new DayPlan
    //         {
    //             DayPlanId = -1,
    //             Recipes = null,
    //             CalorieCount = null
    //         };

    //         // builder.Entity<WeekPlan>().HasData(
    //         //     new WeekPlan
    //         //     {
    //         //         WeekPlanId = -1,
    //         //         UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9",
    //         //         Monday = dayplan,
    //         //         Tuesday = dayplan,
    //         //         Wednesday = dayplan,
    //         //         Thursday = dayplan,
    //         //         Friday = dayplan,
    //         //         Saturday = dayplan,
    //         //         Sunday = dayplan
    //         //     }
    //         // );

    //         builder.Entity<WeekPlan>(b =>
    // {
    //     b.HasData(new WeekPlan
    //     {
    //         WeekPlanId = -1,
    //         UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9",
    //         Monday = dayplan,
    //         Tuesday = dayplan
    //         // Wednesday = dayplan,
    //         // Thursday = dayplan,
    //         // Friday = dayplan,
    //         // Saturday = dayplan,
    //         // Sunday = dayplan
    //     });
    //     b.OwnsOne(e => e.Monday).HasData(dayplan);
    //     b.OwnsOne(e => e.Tuesday).HasData(dayplan);
    // });
    //     }
    }
}