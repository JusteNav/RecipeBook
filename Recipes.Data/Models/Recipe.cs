﻿using RecipeBook.Data.Constants;
using System.ComponentModel.DataAnnotations;

namespace RecipeBook.Data.Models
{
    public class Recipe
    {
        [Required]
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public RecipeCategory Category { get; set; }
        [Display(Name = "Picture Title")]
        public string PictureTitle { get; set; }
        [Required]
        public ICollection<Ingredient> Ingredients { get; set; } //to set up many-to-many relationship;        [Required]
        [Required]
        public ICollection<Step> Steps { get; set; } //to set up one-to-many relationship;
    }
}
