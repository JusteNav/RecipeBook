using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using RecipeBook.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Data
{
    public static class DataSeedHelper
    {
        public static void Seed(this ModelBuilder builder)
        {
            var recipe1 = new Recipe
            {
                Id = Guid.NewGuid(),
                Title = "Thin Pancakes",
                Category = Constants.RecipeCategory.MainCourse,
                PictureTitle = "1",
                Note = "I always pour on the pancake batter using a measuring cup, so I end up with consistently-sized pancakes.",
            };

            var ingredient11 = new Ingredient
            {
                Id = Guid.NewGuid(),
                FullTitle = "1 cup flour",
                Category = Constants.IngredientType.Flour,
                RecipeId = recipe1.Id
            };
            var ingredient12 = new Ingredient
            {
                Id = Guid.NewGuid(),
                FullTitle = "2 eggs",
                Category = Constants.IngredientType.Eggs,
                RecipeId = recipe1.Id
            };
            var ingredient13 = new Ingredient
            {
                Id = Guid.NewGuid(),
                FullTitle = "1 1/4 cups milk",
                Category = Constants.IngredientType.Milk,
                RecipeId = recipe1.Id
            };
            var ingredient14 = new Ingredient
            {
                Id = Guid.NewGuid(),
                FullTitle = "1 teaspoon sugar",
                Category = Constants.IngredientType.Sugar,
                RecipeId = recipe1.Id
            };
            var ingredient15 = new Ingredient
            {
                Id = Guid.NewGuid(),
                FullTitle = "A pinch of salt (tip of the teaspoon)",
                RecipeId = recipe1.Id
            };
            var ingredient16 = new Ingredient
            {
                Id = Guid.NewGuid(),
                FullTitle = "Oil for frying",
                Category = Constants.IngredientType.Oil,
                RecipeId = recipe1.Id
            };

            var step11 = new Step
            {
                Id = Guid.NewGuid(),
                Text = "Sift the flour, sugar and salt, make a well in it.",
                RecipeId = recipe1.Id
            };
            var step12 = new Step
            {
                Id = Guid.NewGuid(),
                Text = "Crack in the eggs, add a bit of the milk.",
                RecipeId = recipe1.Id
            };
            var step13 = new Step
            {
                Id = Guid.NewGuid(),
                Text = "Then start whisking it all together (you can use a mixer).",
                RecipeId = recipe1.Id
            };
            var step14 = new Step
            {
                Id = Guid.NewGuid(),
                Text = "Next, whisk in the rest of the milk and until you have a pancake batter that resembles the consistency of whipping cream.",
                RecipeId = recipe1.Id
            };
            var step15 = new Step
            {
                Id = Guid.NewGuid(),
                Text = "Add on a bit of oil, and quickly swirl it around the pan. Make sure your pan is evenly nice and hot before you start cooking the pancakes. If the pan isn't hot enough, the recipe won't work.",
                RecipeId = recipe1.Id
            };
            var step16 = new Step
            {
                Id = Guid.NewGuid(),
                Text = "Then pour on the pancake batter and quickly swirl it around.",
                RecipeId = recipe1.Id
            };
            var step17 = new Step
            {
                Id = Guid.NewGuid(),
                Text = "Cook until the batter is no longer liquid.",
                RecipeId = recipe1.Id
            };
            var step18 = new Step
            {
                Id = Guid.NewGuid(),
                Text = "Serve with jam, sour cream, ice cream with berries and fruits - whatever you want!",
                RecipeId = recipe1.Id
            };

            var recipe2 = new Recipe
            {
                Id = Guid.NewGuid(),
                Title = "Apple and Carrot Salad",
                Category = Constants.RecipeCategory.Salad,
                PictureTitle = "2",
                Note = "If you won't immediately consume the salad, spray it with a little bit of lemon juice and leave it in the fridge. Consume the same day though.",
            };

            var ingredient21 = new Ingredient
            {
                Id = Guid.NewGuid(),
                FullTitle = "4 apples",
                Category = Constants.IngredientType.Apples,
                RecipeId = recipe2.Id
            };
            var ingredient22 = new Ingredient
            {
                Id = Guid.NewGuid(),
                FullTitle = "4 carrots",
                Category = Constants.IngredientType.Carrots,
                RecipeId = recipe2.Id
            };
            var ingredient23 = new Ingredient
            {
                Id = Guid.NewGuid(),
                FullTitle = "2 tablespoons sour cream",
                Category = Constants.IngredientType.SourCream,
                RecipeId = recipe2.Id
            };
            var ingredient24 = new Ingredient
            {
                Id = Guid.NewGuid(),
                FullTitle = "2 teaspoons sugar (optional)",
                RecipeId = recipe2.Id
            };

            var step21 = new Step
            {
                Id = Guid.NewGuid(),
                Text = "Wash, peel and grate apples and carrots. Combine.",
                RecipeId = recipe2.Id
            };
            var step22 = new Step
            {
                Id = Guid.NewGuid(),
                Text = "Add sugar and sour cream. Mix everything thoroughly so that the sugar melts to the maximum.",
                RecipeId = recipe2.Id
            };
            var step23 = new Step
            {
                Id = Guid.NewGuid(),
                Text = "Serve the delicious salad to the table.",
                RecipeId = recipe2.Id
            };

            var recipe3 = new Recipe
            {
                Id = Guid.NewGuid(),
                Title = "Carrot and Apple Juice",
                Category = Constants.RecipeCategory.Juice,
                PictureTitle = "6"
            };

            var ingredient31 = new Ingredient
            {
                Id = Guid.NewGuid(),
                FullTitle = "4 carrots, trimmed",
                Category = Constants.IngredientType.Carrots,
                RecipeId = recipe3.Id
            };
            var ingredient32 = new Ingredient
            {
                Id = Guid.NewGuid(),
                FullTitle = "2 apples, quartered",
                Category = Constants.IngredientType.Apples,
                RecipeId = recipe3.Id
            };
            var ingredient33 = new Ingredient
            {
                Id = Guid.NewGuid(),
                FullTitle = "2 stalks celery (optional)",
                RecipeId = recipe3.Id
            };
            var ingredient34 = new Ingredient
            {
                Id = Guid.NewGuid(),
                FullTitle = "1,5 cm piece of fresh ginger (optional)",
                RecipeId = recipe3.Id
            };

            var step31 = new Step
            {
                Id = Guid.NewGuid(),
                Text = "Run carrots, apples, (celery) through a juicer, alternating carrot, apple, and, optionally, celery, according to manufacturer's instructions.",
                RecipeId = recipe3.Id
            };
            var step32 = new Step
            {
                Id = Guid.NewGuid(),
                Text = "Add ginger to juicer and process (optional).",
                RecipeId = recipe3.Id
            };

            builder.Entity<Recipe>().HasData(
                recipe1,
                recipe2,
                recipe3
                );

            builder.Entity<Ingredient>().HasData(
                ingredient11,
                ingredient12,
                ingredient13,
                ingredient14,
                ingredient15,
                ingredient16,
                ingredient21,
                ingredient22,
                ingredient23,
                ingredient24,
                ingredient31,
                ingredient32,
                ingredient33,
                ingredient34
                );

            builder.Entity<Step>().HasData(
                step11,
                step12,
                step13,
                step14,
                step15,
                step16,
                step17,
                step18,
                step21,
                step22,
                step23,
                step31,
                step32
                );
        }
    }
}
