using RecipeBook.Data.Constants;
using System.ComponentModel.DataAnnotations;

namespace RecipeBook.Data.Models
{
    public class Ingredient
    {
        [Required]
        [Key]
        public Guid Id { get; set; }
        [Display(Name = "Title")]
        public string? FullTitle { get; set; }
        public IngredientType? Category { get; set; }
        public Recipe? Recipe { get; set; } //to set up one-to-many relationship;
        public Guid? RecipeId { get; set; }
    }
}
