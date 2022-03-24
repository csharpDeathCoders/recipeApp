using Microsoft.AspNetCore.Identity;
using RecipeApp.Models;

namespace RecipeApp.Data
{
    public class IdentitySeedData
    {
        public static async Task Initialize(ApplicationDbContext context,
        UserManager<ApplicationUser> userManager)
        {
            context.Database.EnsureCreated();

            string password4all = "P@$$w0rd";

            if (await userManager.FindByNameAsync("aa@aa.aa") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "aa@aa.aa",
                    Email = "aa@aa.aa",
                    FirstName = "Adam",
                    LastName = "Aldridge",
                    PhoneNumber = "6902341234"
                };
                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password4all);

                }
            }
            if (await userManager.FindByNameAsync("bb@bb.bb") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "bb@bb.bb",
                    Email = "bb@bb.bb",
                    FirstName = "Bob",
                    LastName = "Barker",
                    PhoneNumber = "7788951456"
                };
                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password4all);
                }
            }
            if (await userManager.FindByNameAsync("mm@mm.mm") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "mm@mm.mm",
                    Email = "mm@mm.mm",
                    FirstName = "Mike",
                    LastName = "Myers",
                    PhoneNumber = "6572136821"
                };
                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password4all);
                }
            }
            if (await userManager.FindByNameAsync("dd@dd.dd") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "dd@dd.dd",
                    Email = "dd@dd.dd",
                    FirstName = "Donald",
                    LastName = "Duck",
                    PhoneNumber = "6041234567"
                };
                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password4all);
                }
            }
        }
    }
}