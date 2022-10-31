﻿using Microsoft.Extensions.ObjectPool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Data.Constants
{
    public static class EnumHelper
    {
        private static readonly string[] IngredientCategories = Enum.GetNames<IngredientType>();

        public static readonly int[] IngredientIDs = IngredientCategories.Select(c => GetEnumID(c, typeof(IngredientType))).ToArray();

        public static readonly string[] IngredientCategoryText = IngredientCategories.Select(category => GetValueOrDescriptionString(category, typeof(IngredientType))).ToArray();

        public static readonly string[] RecipeCategories = Enum.GetNames<RecipeCategory>();
        public static readonly int[] RecipeCategoryIDs = RecipeCategories.Select(c => GetEnumID(c, typeof(RecipeCategory))).ToArray();
        public static readonly string[] RecipeCategoryText= RecipeCategories.Select(category => GetValueOrDescriptionString(category, typeof(RecipeCategory))).ToArray();


        //Method returns either the value or a Description or, if there is no description, the value of an enum.
        public static string GetValueOrDescriptionString(string enumString, Type enumType)
        {
            var enumVal = Enum.Parse(enumType, enumString);

            var memInfo = enumType.GetMember(enumVal.ToString());

            var Description = (DescriptionAttribute)Attribute.GetCustomAttribute(memInfo[0], typeof(DescriptionAttribute), false);

            return (Description != null) ? Description.Description: enumVal.ToString();
        }

        public static int GetEnumID(string enumString, Type enumType)
        {
            var enumVal = Enum.Parse(enumType, enumString);

            return (int)enumVal;
        }
    }
}
