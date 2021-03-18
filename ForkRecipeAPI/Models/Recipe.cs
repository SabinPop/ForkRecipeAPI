using System;
using System.Collections.Generic;

namespace ForkRecipeAPI
{
    public class Recipe
    {
        private int id;
        private string title;
        private string description;
        private ICollection<Ingredient> ingredients;
        private ICollection<Spice> spices;

        public int ID { get => id; private set => id = value; }

        public string Title { get => title; set => title = value; }

        public string Description { get => description; set => description = value; }

        public ICollection<Ingredient> Ingredients { get => ingredients; set => ingredients = value; }

        public ICollection<Spice> Spices { get => spices; set => spices = value; }

    }
}