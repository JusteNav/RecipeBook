using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace RecipeBook.Data.Constants
{
    public enum IngredientType
    {
        Optional,
        Flour,
        Tortillas,
        Pasta,
        //[Description("Rye Bread")]
        [Display(Name = "Rye Bread")]
        RyeBread,
        //[Description("Toast Bread")]
        [Display(Name = "Toast Bread")]
        ToastBread,

        Eggs,
        Salami,
        Ham,
        Bacon,
        //[Description("Crab Meat")]
        [Display(Name = "Crab Meat")]
        CrabMeat,

        Milk,
        //[Description("Sour Cream")]
        [Display(Name = "Sour Cream")]
        SourCream,
       // [Description("Heavy Cream")]
        [Display(Name = "Heavy Cream")]
        HeavyCream,
        //[Description("Cheddar Cheese")]
        [Display(Name = "Cheddar Cheese")]
        CheddarCheese,
        //[Description("Mozzarella Cheese")]
        [Display(Name = "Mozzarella Cheese")]
        MozzarellaCheese,
        Butter,

        Apples,
        Oranges,

        Carrots,
        Potatoes,
       // [Description("Bell Pepper")]
        [Display(Name = "Bell Pepper")]
        BellPepper,
        Cauliflower,
        Cucumber,
        Lettuce,
        Dill,
        Onion,
        Garlic,

        Sugar,
        //[Description("Brown Sugar")]
        [Display(Name = "Brown Sugar")]
        BrownSugar,
        Oil,
       // [Description("Tomato Sauce")]
        [Display(Name = "Tomato Sauce")]
        TomatoSauce,
        Mustard,
       // [Description("Thousand Island Dressing")]
        [Display(Name = "Thousand Island Dressing")]
        ThousandIslandDressing,
        Mayonnaise,
       // [Description("Baking Powder")]
        [Display(Name = "Baking Powder")]
        BakingPowder,
        //[Description("Dark Chocolate Chips")]
        [Display(Name = "Dark Chocolate Chips")]
        DarkChocolateChips,
    }
}
