namespace RecipeBookAPI.Models
{
    public class RecipeSearchResultsDto
    {
        public List<RecipeSearchDto> Results { get; set; }
        public PaginationDto Pagination { get; set; }
    }
}
