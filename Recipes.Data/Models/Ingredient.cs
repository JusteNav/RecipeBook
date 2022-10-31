using RecipeBook.Data.Constants;
using System.ComponentModel.DataAnnotations;

namespace RecipeBook.Data.Models
{
    public class Ingredient
    {
        [Required]
        [Key]
        public Guid Id { get; set; }
        [Required]
        [Display(Name = "Title")]
        public string FullTitle { get; set; }
        [Required]
        public IngredientType Category { get; set; }
        [Required]
        public Guid RecipeId { get; set; } //to set up one-to-many relationship;
        [Required]
        public Recipe Recipe { get; set; }
    }
}
