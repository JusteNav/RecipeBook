using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.Extensions.Hosting;
using RecipeBook;
using RecipeBook.Data.Models;

namespace RecipeBook.Pages.Recipes
{
    public class DeleteModel : PageModel
    {
        private readonly RecipeBook.Data.RecipeContext _context;
        private IWebHostEnvironment _environment;

        public DeleteModel(RecipeBook.Data.RecipeContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        [BindProperty]
      public Recipe Recipe { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Recipes == null)
            {
                return NotFound();
            }

            var recipe = await _context.Recipes.FirstOrDefaultAsync(m => m.Id == id);

            if (recipe == null)
            {
                return NotFound();
            }
            else 
            {
                Recipe = recipe;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null || _context.Recipes == null)
            {
                return NotFound();
            }
            var recipe = await _context.Recipes
                                .Include(c => c.Steps)
                                .Include(c => c.Ingredients)
                                .FirstOrDefaultAsync(c => c.Id == id);

            if (recipe != null)
            {
                Recipe = recipe;
                foreach(var step in recipe.Steps)
                {
                    _context.Steps.Remove(step);
                }
                foreach (var ingredient in recipe.Ingredients)
                {
                    _context.Ingredients.Remove(ingredient);
                }

                _context.Recipes
                    .Remove(Recipe);
                await _context.SaveChangesAsync();
            }

            var path = Path.Combine(_environment.ContentRootPath, "wwwroot/images", Recipe.PictureTitle);

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            return RedirectToPage("./Index");
        }
    }
}
