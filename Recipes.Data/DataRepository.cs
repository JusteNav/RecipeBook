using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using RecipeBook.Data.Constants;
using RecipeBook.Data.Interfaces;
using RecipeBook.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Data
{
    public class DataRepository : IDataRepository
    {
        private readonly RecipeContext _context;

        public DataRepository(RecipeContext context)
        {
            _context = context;
        }

        public async Task<Recipe> AddRecipe(Recipe recipe)
        {
            var result = await _context.Recipes
                .AddAsync(recipe);

            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async void DeleteRecipe(Guid id)
        {
            var result = await _context.Recipes
                .Include(r => r.Ingredients)
                .Include(r => r.Steps)
                .FirstOrDefaultAsync(r => r.Id == id);

            if (result != null)
            {
                _context.Recipes.Remove(result);
                await _context.SaveChangesAsync();
            }
        }

        public Dictionary<int, string> GetIngredientTypes(string? search)
        {
            var ret = new Dictionary<int, string>();
            if (string.IsNullOrEmpty(search))
            {
                for (int i = 0; i < EnumHelper.IngredientIDs.Length; i++)
                {
                    ret.Add(EnumHelper.IngredientIDs[i], EnumHelper.IngredientCategoryText[i]);
                }
                
            }
            else
            {
                foreach (var result in EnumHelper.IngredientCategoryText.Where(i => i.ToLower().Contains(search.ToLower())))
                {
                    ret.Add(EnumHelper.GetEnumID(result, typeof(IngredientType)), result);
                }
            }

            return ret;
        }

        public async Task<Recipe> GetRecipe(Guid id)
        {
            return await _context.Recipes
                .Include(r => r.Ingredients)
                .Include(r => r.Steps)
                .FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<IEnumerable<Recipe>> GetRecipes()
        {
            return await _context.Recipes.ToListAsync();
        }

        public async Task<IEnumerable<Recipe>> GetRecipesByCategory(int[] category)
        {
            var result = await _context.Recipes
                .Where(r => 
                category.Contains((int)r.Category))
                .ToListAsync();
            return result;
        }

        public async Task<IEnumerable<Recipe>> GetRecipes(int[] ingredients)
        {
            var result = new List<Recipe>();
                //list of ingredient categories for all the recipes
            var recipeIngredientCategories = await _context.Recipes.Select(r => r.Ingredients.Select(i => (int)i.Category).ToList()).ToListAsync();
            //removing the value 0, since it stands for "optional" category which does not factor in the search
            foreach (List<int> category in recipeIngredientCategories)
            {
                category.RemoveAll(a => a == 0);
            }
            //list of all the recipes
            var recipesToLookThrough = await _context.Recipes.ToListAsync();

            //for each recipe we check if its ingredients are a subset of the query ingredients

            for (int i = 0; i < recipesToLookThrough.Count; i++)
            {
                if (recipeIngredientCategories[i].All(a => ingredients.Contains(a)))
                {
                    result.Add(recipesToLookThrough[i]);
                }
            }
            return result;
        }

        public async Task<Recipe> UpdateRecipe(Recipe recipe)
        {
            var result = await _context.Recipes
                .Include(r => r.Ingredients)
                .Include(r => r.Steps)
                .FirstOrDefaultAsync(r => r.Id == recipe.Id);

            if (result != null)
            {
                result.Title = recipe.Title;
                result.Category = recipe.Category;
                result.PictureTitle = recipe.PictureTitle;
                result.Note = recipe.Note;
                result.Ingredients = recipe.Ingredients;
                result.Steps = recipe.Steps;

                await _context.SaveChangesAsync();

                return result;
            }
            return null;
        }
    }
}
