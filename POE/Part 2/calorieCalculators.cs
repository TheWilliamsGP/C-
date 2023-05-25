using System;
using POE;
using static POE.Recipe;

namespace POE
{
	public class calorieCalculators
	{

		public calorieCalculators()
		{}
        private recipeBook recipebook = new recipeBook();
        Recipe recipe = new Recipe(recname);
        private static string recname;

        // Calculated if the calories are above the limit
        public void calorieCalculator()
        {
            Recipe recipe = new Recipe(recname);
            int totalCalories = 0;
            foreach (var ingredient in recipe.Ingredients)
            {
                totalCalories += ingredient.Calories;
            }

            Console.WriteLine($"\nTotal calories: {totalCalories}");

            if (totalCalories > 300)
            {
                Calorie calorie = caloiresExceeded;
                calorie.Invoke("\nWarning: The recipe exceeds 300 calories!");
            }
            else
            {
                Calorie calorie = caloiresEnough;
                calorie("\nRecipe is healthy");
            }

        }
    }
}

