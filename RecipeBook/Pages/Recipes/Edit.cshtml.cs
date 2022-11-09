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
            Recipe.Steps = _recipe.Steps;
            Recipe.Ingredients = _recipe.Ingredients; 
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            ModelState.Clear();
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Picture != null)
            {
                string? path;
                if(Recipe.PictureTitle != null)
                {
                    path = Path.Combine(_environment.ContentRootPath, "wwwroot/images", Recipe.PictureTitle);
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
                Recipe.PictureTitle = _recipe.PictureTitle;
            }

            _context.Attach(Recipe).State = EntityState.Modified;

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
