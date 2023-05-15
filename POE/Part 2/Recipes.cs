using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;
using POE;
using static System.Formats.Asn1.AsnWriter;

namespace POE

{
    class Ingredient
    {
        public string recipename { get; set; }
        public string ingrediant { get; set; }
        public double quantities { get; set; }
        public string units { get; set; }
        public double Quantity { get; set; }
        public int Calories { get; set; }


        public Ingredient(string ingrediants, double quantity, string unit, int calories)
        {
            //recipename = recname;
            ingrediant = ingrediants;
            quantities = quantity;
            units = unit;
            Quantity = quantity;
            Calories = calories;

        }

    }
    class Recipe
    {
        public List<Ingredient> Ingredients { get; set; }
        public List<string> Steps { get; set; }
        public string recipeName { get; set; }


        public Recipe(string recname)
        {
            recipeName = recname;
            Ingredients = new List<Ingredient>();
            Steps = new List<string>();


        }
    }
        class recipeBook
        {
            private List<Recipe> recipes;
        
            public recipeBook()
            {
            
            recipes = new List<Recipe>();
            
        }

            public void newRecipe(Recipe recipe)
            {
                recipes.Add(recipe);
            }

            public void RemoveRecipe(Recipe recipe)
            {
                recipes.Remove(recipe);
            }

            public List<Recipe> GetRecipeList()
            {
            
            return recipes;
           
        }

            public Recipe GetRecipeByName(string recname)
            {
                foreach (Recipe recipe in recipes)
                {
                    if (recipe.recipeName == recname)
                    {
                        return recipe;
                    }
                }
                return null;
            }
        }



        internal class Recipes1
        {
            //private recipeBook RecipeBook;
            //public rb()
            //{
            //    RecipeBook = new recipeBook();
            //}

            // recipeBook rb = new recipeBook();
            private recipeBook recipebook = new recipeBook();
            //public Recipes()
            //{
            //    recipebook 
            //}

            Recipe recipe = new Recipe(recname);
            private static string recname;

            public void newRecipe()
            {

                Console.WriteLine("Enter the name of recipe:");
                string recipename = Console.ReadLine();

                Recipe recipe = new Recipe(recipename);

                // Prompt user for recipe details
                Console.WriteLine("Enter the number of ingredients:");

                int numIngredients = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < numIngredients; i++)
                {
                    Console.WriteLine("Enter the name of ingredient " + $"{i + 1} :");
                    String ingrediants = Console.ReadLine();



                    Console.WriteLine("Enter the quantity of ingredient " + $"{i + 1}:");
                    double quantities = Convert.ToDouble(Console.ReadLine());



                    Console.WriteLine("Enter the unit of measurement for ingredient " + $"{i + 1}:");
                    String units = Console.ReadLine();

                    Console.WriteLine($"Enter ingredient {i + 1} calories:");
                    int calories = Convert.ToInt32(Console.ReadLine());


                    recipe.Ingredients.Add(new Ingredient(ingrediants, quantities, units, calories));

                }
                Console.WriteLine("Enter the number of steps:");
                int numSteps = Convert.ToInt32(Console.ReadLine());



                for (int i = 0; i < numSteps; i++)
                {
                    Console.WriteLine("Enter the description of step " + $"{i + 1}:");
                    string steps = Console.ReadLine();
                    recipe.Steps.Add(steps);

                }

                recipebook.newRecipe(recipe);
                Console.WriteLine($"Recipe'{recipename}' wass added");
            }

        public void Display()
        {

            Console.WriteLine("List of recipes");

            foreach (Recipe recipe in recipebook.GetRecipeList())

            {

                Console.WriteLine(recipe.recipeName);
            }
        
            Console.WriteLine("\n Enter a recipe name to view ingredients");
            string name = Console.ReadLine();

        
 
            
            if (recipebook.GetRecipeByName != null)
            {
                Console.WriteLine($"Recipe {name}");
                Console.WriteLine("________________________________\nIngredients:\n________________________________");
                foreach (var ingredient in recipe.Ingredients)
                {

                    Console.WriteLine($"{ingredient.quantities} {ingredient.units} of {ingredient.ingrediant},\n{ingredient.Calories} calories");
                }

                Console.WriteLine("________________________________\nSteps:\n________________________________");
                for (int i = 0; i < recipe.Steps.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {recipe.Steps[i]}");
                }
                int totalCalories = 0;
                foreach (var ingredient in recipe.Ingredients)
                {
                    totalCalories += ingredient.Calories;
                }

                Console.WriteLine($"Total calories: {totalCalories}");

                if (totalCalories > 300)
                {
                    Console.WriteLine("Warning: The recipe exceeds 300 calories!");
                }
                else
                {
                    Console.WriteLine("Recipe is healthy");
                }

            }

            //ConsoleColor prevColor = Console.ForegroundColor;
            //Console.ForegroundColor = ConsoleColor.Yellow;

            //foreach (var ingredient in rec.Ingredients)
            //{
            //    Console.WriteLine("Recipe Name: " + $"{ingredient.recipename}");
            //}
            //Console.ForegroundColor = prevColor;

            //Console.WriteLine("________________________________\nIngredients:\n________________________________");
            //foreach (var ingredient in recipe.Ingredients)
            //{

            //    Console.WriteLine($"{ingredient.quantities} {ingredient.units} of {ingredient.ingrediant},\n{ingredient.Calories} calories");
            //}

            //Console.WriteLine("________________________________\nSteps:\n________________________________");
            //for (int i = 0; i < recipe.Steps.Count; i++)
            //{
            //    Console.WriteLine($"{i + 1}. {recipe.Steps[i]}");
            //}

            //int totalCalories = 0;
            //foreach (var ingredient in recipe.Ingredients)
            //    {
            //    totalCalories += ingredient.Calories;
            //    }

            //Console.WriteLine($"Total calories: {totalCalories}");

            //if (totalCalories > 300)
            //{
            //    Console.WriteLine("Warning: The recipe exceeds 300 calories!");
            //}else
            //{
            //    Console.WriteLine("Recipe is healthy");
            //}
        }
            public void Scaling()
            {
                //    double factor;

                //    Console.WriteLine("\nEnter the scale factor (0.5, 2, or 3): ");
                //    factor = Convert.ToDouble(Console.ReadLine());

                //    foreach (var ingredient in recipe.Ingredients)
                //    {
                //        ingredient.quantities *= factor;
                //    }
                }

               public void Reset()
                {
            //    foreach (var ingredient in recipe.Ingredients)
            //    {

            //        ingredient.quantities = ingredient.Quantity;
            //    }
        }
        public void Clear()
            {

                //recipe.Ingredients.Clear();
            }
        }
    }
