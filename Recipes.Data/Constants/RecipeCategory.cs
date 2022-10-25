using System.ComponentModel;

namespace RecipeBook.Data.Constants
{
    public enum RecipeCategory
    {
        Salad,
        Soup,
        [Description("Main Course")]
        MainCourse,
        Dessert,
        Juice,
        Sandwitch
    }
}
