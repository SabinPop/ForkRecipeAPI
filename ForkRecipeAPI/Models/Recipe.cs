using System;
using System.Collections.Generic;

namespace ForkRecipeAPI
{
    public class Recipe
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        // public ICollection<Ingredient> Ingredients { get; set; }

        // public ICollection<Spice> Spices { get; set; }


        public virtual ICollection<Ingredient> Ingredients { get; set; }
        public virtual ICollection<Spice> Spices { get; set; }
    }
}