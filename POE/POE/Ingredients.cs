using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE
{

    // class to store all the getters and setters for the ingredient details
    public class Ingredients
    {
        public string ingredient { get; set; }
        public double quantities { get; set; }
        public string units { get; set; }
        public double Quantity { get; set; }
        public int Calories { get; set; }
        public string foodGroup { get; set; }
        

        public Ingredients(string ingredients, double quantity, string unit, int calories, string foodGrp)
        {

           ingredient = ingredients;
           quantities = quantity;
           units = unit;
           Quantity = quantity;
           Calories = calories;
           foodGroup = foodGrp;
        }
    }
   
}
