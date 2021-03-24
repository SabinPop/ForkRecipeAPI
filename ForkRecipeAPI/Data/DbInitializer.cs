using System;
using System.Linq;

namespace ForkRecipeAPI.Data
{
    public class DbInitializer 
    {
        public static void Initialize(RecipesContext context)
        {
            context.Database.EnsureCreated();

            // look for any recipes in the DB
            if (context.Recipes.Any())
                return;

            // if not then populate the DB
            
            /*
            
            var spices = new Spice[]
            {
                //new Spice { SpiceID = 0, SpiceName = ""},
                new Spice{ SpiceID = 1, SpiceName = "Sare" },
                new Spice{SpiceID = 2, SpiceName = "Piper"}
            };

            foreach(Spice spice in spices)
            {
                context.Spices.Add(spice);
            }
            context.SaveChanges();

            var ingredients = new Ingredient[]
            {
                //new Ingredient{ IngredientID = 0, IngredientName = ""},
                new Ingredient{ IngredientID = 1, IngredientName = "Cartofi"},
                new Ingredient{ IngredientID = 2, IngredientName = "Ceapa" },
                new Ingredient{ IngredientID = 3, IngredientName = "Piept de pui"}
            };

            foreach(Ingredient ingredient in ingredients)
            {
                context.Ingredients.Add(ingredient);
            }
            context.SaveChanges();

            var recipeIngredients = new RecipeIngredient[]
            {
                new RecipeIngredient { RecipeID = 1, IngredientID = 1},
                new RecipeIngredient { RecipeID = 1, IngredientID = 3}
            };

            foreach(var ri in recipeIngredients)
            {
                context.RecipeIngredients.Add(ri);
            }
            context.SaveChanges();

            var recipeSpices = new RecipeSpice[]
            {
                new RecipeSpice { RecipeID = 1, SpiceID = 1},
                new RecipeSpice { RecipeID = 1, SpiceID = 2}
            };

            foreach(var rs in recipeSpices)
            {
                context.RecipeSpices.Add(rs);
            }
            context.SaveChanges();

            var recipes = new Recipe[]
            {
                new Recipe {
                    RecipeID = 1,
                    RecipeTitle = "pui cu cartofi",
                    RecipeDescription = "descriere ... \n descriere2",
                    RecipeIngredients = recipeIngredients,
                    RecipeSpices = recipeSpices
                }
            };

            foreach(var r in recipes)
            {
                context.Recipes.Add(r);
            }
            context.SaveChanges();

            */
        }
    }
}
