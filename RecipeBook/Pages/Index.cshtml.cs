using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using RecipeBook.Data.Constants;
using RecipeBook.Data.Models;
using System.ComponentModel;
using System.Linq;

namespace RecipeBook.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public int[] CheckedCategories { get => checkedCategories; set => checkedCategories = value; }
        private int[] checkedCategories;

        public Dictionary<string, string> DictIDs {get; private set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        
        public IActionResult OnGetAsync()
        {
            checkedCategories = null;
            return Page();
        }

        public IActionResult OnPostAsync()
        {
            DictIDs = new Dictionary<string, string> { { "passedIDs", JsonConvert.SerializeObject(checkedCategories) } };

            return RedirectToPage("/Recipes/Index", DictIDs);
        }
    }
}