using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using RecipeBook;
using RecipeBook.Data.Constants;
using RecipeBook.Data.Models;

namespace RecipeBook.Pages.Recipes
{
    public class EditModel : PageModel
    {
        private readonly Data.RecipeContext _context;
        private IWebHostEnvironment _environment;

        public EditModel(Data.RecipeContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        [BindProperty]
        public Recipe Recipe { get; set; } = default!;

        private Recipe _recipe { get; set; }
        [BindProperty]
        public List<Ingredient> Ingredients { get; set; }
        [BindProperty]
        public List<Step> Steps { get; set; }

        [BindProperty]
        public IFormFile? Picture { get; set; }
        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Recipes == null)
            {
                return NotFound();
            }

            _recipe = await _context.Recipes
                                .Include(c => c.Steps)
                                .Include(c => c.Ingredients)
                                .FirstOrDefaultAsync(c => c.Id == id);
            if (_recipe == null)
            {
                return NotFound();
            }
            Recipe = _recipe;
            Steps = _recipe.Steps.OrderBy(n => n.StepNumber).ToList();
            Ingredients = _recipe.Ingredients.ToList(); 
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            ModelState.Clear();
            var oldPictureTitle = await _context.Recipes
                .Where(i => i.Id == Recipe.Id)
                .Select(c => c.PictureTitle)
                .FirstOrDefaultAsync();

            Ingredients.RemoveAll(c => string.IsNullOrEmpty(c.FullTitle) || c.Category == null);
            Steps.RemoveAll(c => string.IsNullOrEmpty(c.Text));
            Ingredients.Select(i => Enum.Parse(typeof(IngredientType), i.Category.ToString()));

            Recipe.Ingredients = Ingredients;
            Recipe.Steps = Steps;


            if (!ModelState.IsValid)
            {
                return Page();
            }


            if (Picture != null)
            {
                string? path;
                if (oldPictureTitle != null)
                {
                    path = Path.Combine(_environment.ContentRootPath, "wwwroot/images", oldPictureTitle);
                }
                else
                {
                    path = Path.Combine(_environment.ContentRootPath, "wwwroot/images");
                }

                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }

                var path2 = Path.Combine(_environment.ContentRootPath, "wwwroot", "images", Picture.FileName);
                using (var fileStream = new FileStream(path2, FileMode.Create)) //!Not a secure solution - additional security measures would be needed in a real-world scenario
                {
                    await Picture.CopyToAsync(fileStream);
                }

                Recipe.PictureTitle = Picture.FileName;
            }
            else
            {
                Recipe.PictureTitle = oldPictureTitle;
            }


            _context.Attach(Recipe).State = EntityState.Modified;
            foreach(var step in Steps)
            {
                _context.Attach(step).State = EntityState.Modified;
            }
            foreach (var ing in Ingredients)
            {
                _context.Attach(ing).State = EntityState.Modified;
            }

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecipeExists(Recipe.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToPage("./Index");
        }

        private bool RecipeExists(Guid id)
        {
          return _context.Recipes.Any(e => e.Id == id);
        }
    }
}
