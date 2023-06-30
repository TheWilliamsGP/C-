using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE
{
    // class to create list of ingredients, steps and recipe name
    public class Recipes
    {
        public string recipename { get; set; }
        public string steps { get; set; }

        public List<Ingredients> ingredients { get; set; }
        public List<Steps> STEPS { get; set; }

        public Recipes() { 
        ingredients = new List<Ingredients>();
        STEPS = new List<Steps>();
          
        
        }
    }
}
