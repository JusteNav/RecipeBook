using RecipeBook.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeBook.Data.Models
{
    public class Recipe
    {
        [Required]
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public RecipeCategory Category { get; set; }
        [Display(Name = "Picture Title")]
        public string? PictureTitle { get; set; }
        public string? Note { get; set; }
        [Required]
        public ICollection<Ingredient> Ingredients { get; set; } //to set up one-to-many relationship;
        [Required]
        public ICollection<Step> Steps { get; set; } //to set up one-to-many relationship;
        [NotMapped]
        public int[] Categories;

        public void SetCategories()
        {
            Categories = Ingredients.Select(c => (int)c.Category).ToArray();
        }
    }
}
