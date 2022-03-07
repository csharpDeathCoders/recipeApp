namespace recipeApp.Models
{
    public class DayPlan
    {
        public int DayPlanId { get; set; }
        public List<RecipeModel> Recipe { get; set; }
        public int CalorieCount { get; set; }
    }
}