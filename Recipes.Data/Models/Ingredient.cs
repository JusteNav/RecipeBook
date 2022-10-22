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
        public Ingredient Category { get; set; }

        public ICollection<Recipe> Recipes { get; set; } //to set up many-to-many relationship;
    }
}
