using System;
using POE;
using static POE.Recipe;
using static POE.Recipes;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;

namespace POE
{
    public class calorieCalculators
    {

        // private recipeBook recipebook = new recipeBook();
        Recipe recipe = new Recipe(recname);
        public static string recname;
        int totalCalories;
        class Delegate_Calories
        {
            public delegate void Calorie();

            public class delegate_calories
            {

                private recipeBook recipebook = new recipeBook();
                Recipe recipe = new Recipe(recname);
                public static string recname;

                public static void error_display()
                {
                    Console.WriteLine("\nWarning: The recipe exceeds 300 calories!");

                }
                public static void caloriesHealthy()
                {
                    Console.WriteLine("\nRecipe is healthy");
                }
                public void calorieCalculator()

                {

                    int totalCalories = 0;
                    foreach (var ingredient in recipe.Ingredients)
                    {
                        totalCalories += ingredient.Calories;

                    }
                    Console.WriteLine($"\nTotal calories: {totalCalories}");


                    if (totalCalories > 300)
                    {
                        Calorie ED = delegate_calories.error_display;
                        ED();
                    }
                    else
                    {
                        Calorie CH = delegate_calories.caloriesHealthy;
                        CH();

                    }

                }


            }


        }
    }
}