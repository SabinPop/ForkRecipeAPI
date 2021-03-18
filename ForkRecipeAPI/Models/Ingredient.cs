using System;

namespace ForkRecipeAPI
{
    public class Ingredient
    {
        private string name;
        private int id;

        public int ID { get => id; private set => id = value; }

        public string Name { get => name; set => name = value; }
    }
}