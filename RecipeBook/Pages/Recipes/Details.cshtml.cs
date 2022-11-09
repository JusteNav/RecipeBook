using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecipeBook;
using RecipeBook.Data.Models;

namespace RecipeBook.Pages.Recipes
{
    public class DetailsModel : PageModel
    {
        private readonly RecipeBook.Data.RecipeContext _context;

        public DetailsModel(RecipeBook.Data.RecipeContext context)
        {
            _context = context;
        }

        public Recipe Recipe { get; set; }
        public List<string> Steps { get; set; }
        public List<string> Ingredients { get; set; }
        public string PreviousPage { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            PreviousPage = Request.Headers["Referer"].ToString();

            if (id == null || _context.Recipes == null)
            {
                return NotFound();
            }

            var recipe = await _context.Recipes
                .Include(c => c.Ingredients)
                .Include(c => c.Steps)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recipe == null)
            {
                return NotFound();
            }
            else 
            {
                Recipe = recipe;
                Steps = recipe.Steps.OrderBy(n => n.StepNumber).Select(s => s.Text).ToList();
                Ingredients = recipe.Ingredients.Select(i => i.FullTitle).ToList();
            }            
            return Page();
        }
    }
}
