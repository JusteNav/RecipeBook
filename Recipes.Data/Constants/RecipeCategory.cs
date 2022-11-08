using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecipeBook.Data.Constants
{
    public enum RecipeCategory
    {
        Salad,
        Soup,
        //[Description("Main Course")]
        [Display(Name = "Main Course")]
        MainCourse,
        Dessert,
        Juice,
        Sandwitch
    }
}
