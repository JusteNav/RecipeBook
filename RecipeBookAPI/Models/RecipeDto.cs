using RecipeBook.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace RecipeBookAPI.Models
{
    public class RecipeDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public RecipeCategory Category { get; set; }
        public string? PictureTitle { get; set; }
        public string? Note { get; set; }

        public List<StepDto> Steps { get; set; }    
        public List<IngredientDto> Ingredients { get; set; }
    }
}
