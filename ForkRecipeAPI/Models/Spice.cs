using System;
using System.Collections.Generic;

namespace ForkRecipeAPI
{
    public class Spice
    {
        /*
        public Spice()
        {
            RecipeSpices = new HashSet<RecipeSpice>();
        }
        */

        public int SpiceID { get; set; }

        public string SpiceName { get; set; }

        public virtual ICollection<RecipeSpice> RecipeSpices { get; set; }
    }
}