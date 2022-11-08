using System.ComponentModel.DataAnnotations;

namespace RecipeBook.Data.Models
{
    public class Step
    {
        [Required]
        [Key]
        public Guid Id { get; set; }
        public int? StepNumber { get; set; }
        public string? Text { get; set; }
        public Recipe? Recipe { get; set; } //to set up one-to-many relationship;
        public Guid? RecipeId { get; set; }
    }
}
