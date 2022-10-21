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
        public Recipe Recipe { get; set; } //to set up one-to-many relationship;
    }
}
