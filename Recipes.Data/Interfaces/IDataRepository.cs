using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipeBook.Data.Constants;
using RecipeBook.Data.Models;

namespace RecipeBook.Data.Interfaces
{
    public interface IDataRepository
    {
       
        Task<Recipe> GetRecipe(Guid id);
        Task<Recipe> AddRecipe(Recipe recipe);
        Task<Recipe> UpdateRecipe(Recipe recipe);
        void DeleteRecipe(Guid id);


        Task<IEnumerable<Recipe>> GetRecipes();
        Task<IEnumerable<Recipe>> GetRecipesByCategory(int[] category);
        Task<IEnumerable<Recipe>> GetRecipes(int[] ingredients);

        Dictionary<int,string> GetIngredientTypes(string? search);
    }
}
