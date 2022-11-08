using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeBook.Data.Models;

namespace RecipeBook.Data

{
    public class RecipeContext : DbContext
    {
        public RecipeContext (DbContextOptions<RecipeContext> options)
            : base(options)
        {
        }

        public DbSet<Recipe> Recipes { get; set; } = default!;
        public DbSet<Ingredient> Ingredients { get; set; } = default!;
        public DbSet<Step> Steps { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Step>()
                .HasOne(c => c.Recipe)
                .WithMany(e => e.Steps);

            builder.Entity<Ingredient>()
               .HasOne(c => c.Recipe)
               .WithMany(e => e.Ingredients);

            builder.Seed();

        }
    }
}
