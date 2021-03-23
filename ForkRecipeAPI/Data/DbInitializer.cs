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

            var spices = new Spice[]
            {
                new Spice {ID = 0, Name = ""},
                new Spice{ ID = 1, Name = "Sare" },
                new Spice{ ID = 2, Name = "Piper"},
                new Spice{ ID = 3, Name = "Boia"}
            };

            foreach(Spice spice in spices)
            {
                context.Spices.Add(spice);
            }
            context.SaveChanges();

            var ingredients = new Ingredient[]
            {
                new Ingredient{ ID = 0, Name = ""},
                new Ingredient{ ID = 1, Name = "Cartofi"},
                new Ingredient{ ID = 2, Name = "Ceapa" },
                new Ingredient{ ID = 3, Name = "Piept de pui"}
            };

            foreach(Ingredient ingredient in ingredients)
            {
                context.Ingredients.Add(ingredient);
            }
            context.SaveChanges();

            var recipes = new Recipe[]
            {
                new Recipe{ ID = 1,
                    Title = "Cartofi cu piept de pui", 
                    Description = "descriere cartofi cu piept de pui descriere", 
                    Ingredients = { ingredients[1], ingredients[3]} , Spices = {spices[1], spices[2]} }
            };

            foreach(Recipe recipe in recipes)
            {
                context.Recipes.Add(recipe);
            }
            context.SaveChanges();
        }
    }
}
