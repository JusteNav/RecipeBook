using System.ComponentModel.DataAnnotations;

namespace RecipeBook.Data.Models
{
    public class Step
    {
        [Required]
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public Guid RecipeId { get; set; } //to set up one-to-many relationship;
        [Required]
        public Recipe Recipe { get; set; } 
    }
}
