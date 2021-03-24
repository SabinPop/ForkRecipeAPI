using System;
using System.Collections.Generic;

namespace ForkRecipeAPI
{
    public class Recipe
    {
        /*
        public Recipe()
        {
            RecipeIngredients = new HashSet<RecipeIngredient>();
            RecipeSpices = new HashSet<RecipeSpice>();
        }
        */
        public int RecipeID { get; set; }

        public string RecipeTitle { get; set; }

        public string RecipeDescription { get; set; }

        // public ICollection<Ingredient> Ingredients { get; set; }

        // public ICollection<Spice> Spices { get; set; }


        public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; }
        public virtual ICollection<RecipeSpice> RecipeSpices { get; set; }
    }
}