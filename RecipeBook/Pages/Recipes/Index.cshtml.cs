using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using RecipeBook;
using RecipeBook.Data;
using RecipeBook.Data.Constants;
using RecipeBook.Data.Models;

namespace RecipeBook.Pages.Recipes
{
    public class IndexModel : PageModel
    {
        private int[] selectedIDs;
        private readonly RecipeBook.Data.RecipeContext _context;
        public IList<Recipe> DisplayedRecipes { get; set; } = default!;
        public IndexModel(RecipeBook.Data.RecipeContext context)
        {
            _context = context;
        }

       
        public async Task OnGetAsync(string passedIDs)
        {
            if (_context.Recipes != null)
            {
                var recipes = _context.Recipes.Select(c => c);

                IQueryable<Recipe> recipesQuery = new List<Recipe>().AsQueryable();

                if (!string.IsNullOrEmpty(passedIDs) )
                {
                    selectedIDs = JsonConvert.DeserializeObject<int[]>(passedIDs);


                    if(selectedIDs.Length != 0)
                    {
                        //HashSet<IngredientType> selectedIngredients1 = new HashSet<IngredientType>(selectedIDs.Select(c => (IngredientType)c));
                        //IngredientType[] selectedIngredients2 = selectedIDs.Select(c => (IngredientType)c).ToArray();

                        //IQueryable<IngredientType> ingredients = new List<IngredientType>().AsQueryable();

                        //    ingredients = from r in recipes
                        //        from i in r.Ingredients
                        //        select i.Category;

                        //    recipesQuery = recipesQuery.Concat(from r in recipes
                        //                   where selectedIngredients2.All(c => ingredients.Contains(c))
                        //                   select r);

                        ////where selectedIngredients2.All(c => i.Category.ToArray().Contains(c))
                        ////select r;
                        //recipes = recipesQuery;
                    }
                }

                DisplayedRecipes = await recipes.ToListAsync();
            }
        }

        //private IngredientType[] GetIngredientCategories(Recipe recipe)
        //{
        //    IngredientType[] ret = recipe.Ingredients.Select(c => c.Category).ToArray();

        //    return ret;
        //}
    }
}
