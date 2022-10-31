using System.ComponentModel;

namespace RecipeBook.Data.Constants
{
    public enum IngredientType
    {
        Optional,
        Flour,
        Tortillas,
        Pasta,
        [Description("Rye Bread")]
        RyeBread,
        [Description("Toast Bread")]
        ToastBread,

        Eggs,
        Salami,
        Ham,
        Bacon,
        [Description("Crab Meat")]
        CrabMeat,

        Milk,
        [Description("Sour Cream")]
        SourCream,
        [Description("Heavy Cream")]
        HeavyCream,
        [Description("Cheddar Cheese")]
        CheddarCheese,
        [Description("Mozzarella Cheese")]
        MozzarellaCheese,
        Butter,

        Apples,
        Oranges,

        Carrots,
        Potatoes,
        [Description("Bell Pepper")]
        BellPepper,
        Cauliflower,
        Cucumber,
        Lettuce,
        Dill,
        Onion,
        Garlic,

        Sugar,
        [Description("Brown Sugar")]
        BrownSugar,
        Oil,
        [Description("Tomato Sauce")]
        TomatoSauce,
        Mustard,
        [Description("Thousand Island Dressing")]
        ThousandIslandDressing,
        Mayonnaise,
        [Description("Baking Powder")]
        BakingPowder,
        [Description("Dark Chocolate Chips")]
        DarkChocolateChips,
    }
}
