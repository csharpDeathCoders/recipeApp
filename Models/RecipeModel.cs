namespace recipeApp.Models
{
    public class RecipeModel
    {
        public int RecipeId { get; set; }
        public List<string> Ingredients { get; set; }
        public List<string> Instructions { get; set; }
        public List<string>? Nutrition { get; set; }
        public bool IsFavourite { get; set; }
    }
}