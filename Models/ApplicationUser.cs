using Microsoft.AspNetCore.Identity;

namespace RecipeApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() : base() { }

        public ApplicationUser(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}