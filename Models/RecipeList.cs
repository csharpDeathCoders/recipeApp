namespace RecipeApp.Models
{
    public class RecipeList
    {
        public int id { get; set; }
        public string? title { get; set; }
        public string? image { get; set; }
        public string? imageType { get; set; }
        public string? usedIngredientCount { get; set; }
        public string? missedIngredientCount { get; set; }
        public List <string>? missedIngredient{ get; set; }
        public List <string>? usedIngredient { get; set; }
        public List <string>? unusedIngredients { get; set; }
        public int? likes { get; set; }

    }
}