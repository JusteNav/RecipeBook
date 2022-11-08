
namespace RecipeBookAPI.Models
{
    public class IngredientSearchResultDto
    {
        public List<IngredientSearchDto> Results { get; set; }

        public PaginationDto Pagination { get; set; }
    }
}
