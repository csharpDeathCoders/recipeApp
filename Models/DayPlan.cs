using Microsoft.EntityFrameworkCore;

namespace RecipeApp.Models
{
    [Owned]
    public class DayPlan
    {
        public int DayPlanId { get; set; }
        public List<Recipe>? Recipes { get; set; }
        public int? CalorieCount { get; set; }
    }
}