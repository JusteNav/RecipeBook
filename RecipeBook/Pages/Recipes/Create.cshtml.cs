using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Build.Framework;
using Microsoft.Extensions.ObjectPool;
using RecipeBook;
using RecipeBook.Data.Constants;
using RecipeBook.Data.Models;

namespace RecipeBook.Pages.Recipes
{
    public class CreateModel : PageModel
    {
        private readonly Data.RecipeContext _context;
        private IWebHostEnvironment _environment;
        public CreateModel(Data.RecipeContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        private Guid _id;

        [BindProperty]
        public IFormFile Picture { get; set; }

        [BindProperty]
        public Recipe Recipe { get; set; }
        [BindProperty]
        public List<Ingredient> Ingredients { get; set; }
        [BindProperty]
        public List<Step> Steps { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            ModelState.Clear(); //why does this work? 
            var path = Path.Combine(_environment.ContentRootPath, "wwwroot", "images", Picture.FileName);
            using (var fileStream = new FileStream(path, FileMode.Create)) //!Not a secure solution - additional security measures would be needed in a real-world scenario
            {
                await Picture.CopyToAsync(fileStream);
            }

            _id = Guid.NewGuid();

            Recipe.Id = _id;
            Recipe.PictureTitle = Picture.FileName.ToString();
            Ingredients.RemoveAll(c => string.IsNullOrEmpty(c.FullTitle) || c.Category == null);
            Steps.RemoveAll(c => string.IsNullOrEmpty(c.Text));
            Ingredients.Select(i => Enum.Parse(typeof(IngredientType), i.Category.ToString()));

            foreach (var ing in Ingredients)
            {
                ing.Id = Guid.NewGuid();
                ing.RecipeId = Recipe.Id;
                ing.Recipe = Recipe;
            }
            foreach (var step in Steps)
            {
                step.Id = Guid.NewGuid();
                step.RecipeId = Recipe.Id;
                step.Recipe = Recipe;
            }
            Recipe.Ingredients = Ingredients;
            Recipe.Steps = Steps;

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Recipes.Add(Recipe);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
