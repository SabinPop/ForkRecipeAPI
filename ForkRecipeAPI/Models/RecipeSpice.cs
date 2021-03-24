using System;

namespace ForkRecipeAPI
{
    public class RecipeSpice
    {
        public int RecipeID { get; set; }
        public Recipe Recipe { get; set; }
        public int SpiceID { get; set; }
        public Spice Spice{ get; set; }
    }
}