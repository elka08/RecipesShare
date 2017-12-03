using RecipesShare.Models;

namespace RecipesShare.Controllers
{
    public interface IRecipeRetriever
    {
        RecipeModel GetRecipeById(int id);
    }
}