using RecipeBook.Data.Constants;

namespace RecipeBookAPI.Models
{
    public class RecipeSearchDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public RecipeCategory Category { get; set; }
        public string PictureTitle { get; set; }
    }
}
