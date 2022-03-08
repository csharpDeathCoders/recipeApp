namespace recipeApp.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string? title { get; set; }
        public string? ImageURL { get; set; }
        public string? Ingredients { get; set; }
        public string? Instructions { get; set; }
        public string? Nutrition { get; set; }
        public bool? IsFavourite { get; set; }
    }
}