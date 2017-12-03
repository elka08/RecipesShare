using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RecipesShare.Controllers
{
    public class RecipeController : Controller
    {
        IRecipeRetriever _recipeRetriever { get; set; }

        public RecipeController()
        {
            _recipeRetriever = new FakeRecipeRetriever();
        }

        public IActionResult Index(int id)
        {
            var recipe = _recipeRetriever.GetRecipeById(id);
            return View();
        }
    }
}