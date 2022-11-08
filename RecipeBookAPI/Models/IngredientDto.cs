using RecipeBook.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace RecipeBookAPI.Models
{
    public class IngredientDto
    {
        public Guid Id { get; set; }
        public string FullTitle { get; set; }
        public IngredientType Category { get; set; }
        public Guid RecipeId { get; set; } 

    }
}
