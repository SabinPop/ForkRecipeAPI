using System;
using System.Collections.Generic;

namespace ForkRecipeAPI
{
    public class Ingredient
    {
        /*
        public Ingredient()
        {
            RecipeIngredients = new HashSet<RecipeIngredient>();
        }
        */
        public int IngredientID { get; set;  }

        public string IngredientName { get; set; }

        public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; }

    }
}