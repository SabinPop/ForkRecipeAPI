using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ForkRecipeAPI.Data
{
    public class RecipesContext : DbContext
    {
        public RecipesContext(DbContextOptions<RecipesContext> options) : base(options)
        {

        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Spice> Spices { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
        public DbSet<RecipeSpice> RecipeSpices { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
            modelBuilder.Entity<Recipe>().ToTable("Recipe");
            modelBuilder.Entity<Ingredient>().ToTable("Ingredient");
            modelBuilder.Entity<Spice>().ToTable("Spice");
            */


            modelBuilder.Entity<RecipeIngredient>()
                        .HasKey(ri => new { ri.RecipeID, ri.IngredientID });

            modelBuilder.Entity<RecipeIngredient>()
                        .HasOne(ri => ri.Recipe)
                        .WithMany(r => r.RecipeIngredients)
                        .HasForeignKey(ri => ri.RecipeID);

            modelBuilder.Entity<RecipeIngredient>()
                        .HasOne(ri => ri.Ingredient)
                        .WithMany(i => i.RecipeIngredients)
                        .HasForeignKey(ri => ri.IngredientID);


            modelBuilder.Entity<RecipeSpice>()
                        .HasKey(rs => new { rs.RecipeID, rs.SpiceID });

            modelBuilder.Entity<RecipeSpice>()
                        .HasOne(rs => rs.Recipe)
                        .WithMany(r => r.RecipeSpices)
                        .HasForeignKey(rs => rs.RecipeID);

            modelBuilder.Entity<RecipeSpice>()
                        .HasOne(rs => rs.Spice)
                        .WithMany(s => s.RecipeSpices)
                        .HasForeignKey(rs => rs.SpiceID);

            /*
             * 
            modelBuilder.Entity<Recipe>()
                        .HasMany(r => r.RecipeIngredients)
                        .WithOne(ri => ri.Recipe)
                        .HasForeignKey(r => r.IngredientID);

            modelBuilder.Entity<Recipe>()
                        .HasMany(r => r.RecipeSpices)
                        .WithOne(rs => rs.Recipe)
                        .HasForeignKey(r => r.SpiceID);

            */
        }
    }
}