using RecipeBook.Data.Models;

namespace RecipeBookAPI.Models
{
    public class StepDto
    {
        public Guid Id { get; set; }
        public int StepNumber { get; set; }
        public string Text { get; set; }
        public Guid RecipeId { get; set; }
    }
}
