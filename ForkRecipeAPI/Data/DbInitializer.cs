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


        }
    }
}
