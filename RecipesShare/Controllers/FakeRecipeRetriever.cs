using RecipesShare.Models;

namespace RecipesShare.Controllers
{
    public class FakeRecipeRetriever : IRecipeRetriever
    {
        public RecipeModel GetRecipeById(int id)
        {
            var recipe = new RecipeModel();


            recipe.ContributorName = "Yehuda Krupka";
            recipe.RecipeDescription = "30 Min Crumb Cake";   
            recipe.RecipeUrl = "https://www.bostoncoffeecake.com/fullsize/11/8";

            return recipe;
        }
    }
}