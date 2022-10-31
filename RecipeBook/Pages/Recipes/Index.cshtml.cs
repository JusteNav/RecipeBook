using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NuGet.Frameworks;
using RecipeBook;
using RecipeBook.Data;
using RecipeBook.Data.Constants;
using RecipeBook.Data.Models;

namespace RecipeBook.Pages.Recipes
{
    public class IndexModel : PageModel
    {
        private int[] selectedIDs;
        private readonly RecipeContext _context;
        public IList<Recipe> DisplayedRecipes { get; set; } = default!;
        public IndexModel(RecipeContext context)
        {
            _context = context;
        }

        public int[] RecipeCategoryIds { get => recipeCategoryIds; set => recipeCategoryIds = value; }
        private int[] recipeCategoryIds = EnumHelper.RecipeCategoryIDs;

        public string[] RecipeCategoriesForPrinting { get => recipeCategoriesForPrinting; set => recipeCategoriesForPrinting = value; }
        private string[] recipeCategoriesForPrinting = EnumHelper.RecipeCategoryText;

        public async Task OnGetAsync(string passedIDs)
        {
            if (_context.Recipes != null)
            {
                var recipes = _context.Recipes.Select(c => c);

                if (!string.IsNullOrEmpty(passedIDs) )
                {
                    //since the query required would be very complex to write and the amount of data is small, the logic is performed client-side
                    DisplayedRecipes = new List<Recipe>();

                    //IDs passed as parameters in the URL
                    selectedIDs = JsonConvert.DeserializeObject<int[]>(passedIDs);

                    if (selectedIDs.Length != 0)
                    {
                        //list of ingredient categories for all the recipes
                        var recipeIngredientCategories = await recipes.Select(r => r.Ingredients.Select(i => (int)i.Category).ToList()).ToListAsync();
                        //removing the value 0, since it stands for "optional" category which does not factor in the search
                        foreach (List<int> category in recipeIngredientCategories)
                        {
                            category.RemoveAll(a => a == 0);
                        }
                        //list of all the recipes
                        var recipesToLookThrough = await recipes.ToListAsync();

                        //for each recipe we check if its ingredients are a subset of the query ingredients

                        for (int i = 0; i < recipesToLookThrough.Count; i++)
                        {
                            if (recipeIngredientCategories[i].All(a => selectedIDs.Contains(a)))
                            {
                                DisplayedRecipes.Add(recipesToLookThrough[i]);
                            }
                        }
                    }
                }
                else
                {
                    DisplayedRecipes = await recipes.ToListAsync();
                }
            }
        }
    }
}
