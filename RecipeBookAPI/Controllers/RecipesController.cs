using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using RecipeBook.Data;
using RecipeBook.Data.Interfaces;
using RecipeBook.Data.Models;
using RecipeBookAPI.Models;
using System.Drawing;

namespace RecipeBookAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class RecipesController : ControllerBase
    {
        private readonly RecipeContext _context;
        private readonly IDataRepository _repo;
        private readonly ILogger<RecipesController> _logger;

        public RecipesController(ILogger<RecipesController> logger, RecipeContext context)
        {
            _logger = logger;
            _context = context;
            _repo = new DataRepository(context);
        }

        [HttpGet]
        public async Task<RecipeSearchResultsDto> GetRecipesByCategory(string? search)
        {
            var result = new RecipeSearchResultsDto();

            IEnumerable<Recipe> recipes;
            if (!string.IsNullOrEmpty(search))
            {
                var selectedIDs = JsonConvert.DeserializeObject<int[]>(search);

                if (selectedIDs.Length == 0)
                {
                    recipes = await _repo.GetRecipes();
                }
                else
                {
                    recipes = await _repo.GetRecipesByCategory(selectedIDs);
                }
            }

            else
            {
                recipes = await _repo.GetRecipes();

            }

            result.Results = recipes.Select(r => new RecipeSearchDto()
            {
                Id = r.Id,
                Title = r.Title,
                Category = r.Category,
                PictureTitle = r.PictureTitle
            }).ToList();

            return result;
        }


        [HttpGet]
        [Route("ByIngredients")]
        public async Task<RecipeSearchResultsDto> GetRecipesByIngredient(string search)
        {
            var result = new RecipeSearchResultsDto();

            IEnumerable<Recipe> recipes;

            var selectedIDs = JsonConvert.DeserializeObject<int[]>(search);

            if (selectedIDs.Length != 0)
            {
                recipes = await _repo.GetRecipes(selectedIDs);
            }
            else
            {
                recipes = await _repo.GetRecipes();
            }

            result.Results = recipes.Select(r => new RecipeSearchDto()
            {
                Id = r.Id,
                Title = r.Title,
                Category = r.Category,
                PictureTitle = r.PictureTitle
            }).ToList();

            return result;

        }

        [HttpGet]
        [Route("IngredientList")]
        public IngredientSearchResultDto GetIngredientCategories(string? search)
        {
            var ingredients = _repo.GetIngredientTypes(search);

            List<IngredientSearchDto> ret = ingredients.Select(c => new IngredientSearchDto()
            {
                Id = c.Key,
                Text = c.Value
            }).ToList();

            return new IngredientSearchResultDto()
            { Results = ret};
        }


        //[HttpGet("{id}")]
        //public async Task<RecipeDto> GetRecipeById(Guid id)
        //{
        //    var result = await _repo.GetRecipe(id);

        //    if (result != null)
        //    {
        //        return new RecipeDto()
        //        {
        //            Id = result.Id,
        //            Title = result.Title,
        //            Category = result.Category,
        //            PictureTitle = result.PictureTitle,
        //            Note = result.Note,

        //            Steps = result.Steps.Select(x => new StepDto()
        //            {
        //                Id = x.Id,
        //                StepNumber = x.StepNumber,
        //                Text = x.Text,
        //                RecipeId = result.Id
        //            }).ToList(),

        //            Ingredients = result.Ingredients.Select(x => new IngredientDto()
        //            {
        //                Id = x.Id,
        //                FullTitle = x.FullTitle,
        //                Category = x.Category,
        //                RecipeId = result.Id
        //            }).ToList()
        //        };
        //    }
        //    else
        //    {
        //        return new RecipeDto();
        //    }

        //}

        [HttpPost]
        public async Task<Recipe> Create(RecipeDto recipe)
        {
            var result = await _repo.AddRecipe(new Recipe()
            {

                Id = recipe.Id,
                Title = recipe.Title,
                Category = recipe.Category,
                PictureTitle = recipe.PictureTitle,
                Note = recipe.Note,

                Steps = recipe.Steps.Select(x => new Step()
                {
                    Id = x.Id,
                    StepNumber = x.StepNumber,
                    Text = x.Text,
                    RecipeId = recipe.Id
                }).ToList(),

                Ingredients = recipe.Ingredients.Select(x => new Ingredient()
                {
                    Id = x.Id,
                    FullTitle = x.FullTitle,
                    Category = x.Category,
                    RecipeId = recipe.Id
                }).ToList()
            });

            return result;
        }

        [HttpPut]
        public async Task<Recipe> Edit(RecipeDto recipe)
        {
            return await _repo.UpdateRecipe(new Recipe()
            {
                Id = recipe.Id,
                Title = recipe.Title,
                Category = recipe.Category,
                PictureTitle = recipe.PictureTitle,
                Note = recipe.Note,

                Steps = recipe.Steps.Select(x => new Step()
                {
                    Id = x.Id,
                    StepNumber = x.StepNumber,
                    Text = x.Text,
                    RecipeId = recipe.Id
                }).ToList(),

                Ingredients = recipe.Ingredients.Select(x => new Ingredient()
                {
                    Id = x.Id,
                    FullTitle = x.FullTitle,
                    Category = x.Category,
                    RecipeId = recipe.Id
                }).ToList()
            });
        }

        [HttpDelete]
        public void Delete(Guid id)
        {
            _repo.DeleteRecipe(id);
            return;
        }
    }
}