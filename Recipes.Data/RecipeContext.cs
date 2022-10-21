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

        public DbSet<RecipeBook.Data.Models.Recipe> Recipe { get; set; } = default!;
    }
}
