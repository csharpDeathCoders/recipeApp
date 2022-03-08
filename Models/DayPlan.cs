namespace recipeApp.Models
{
    public class DayPlan
    {
        public int DayPlanId { get; set; }
        public List<Recipe>? Recipe { get; set; }
        public int? CalorieCount { get; set; }
    }
}