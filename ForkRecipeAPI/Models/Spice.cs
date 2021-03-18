using System;

namespace ForkRecipeAPI
{
    public class Spice
    {
        private int id;

        private string name;

        public int ID { get => id; private set => id = value; }

        public string Name { get => name; set => name = value; }
    }
}