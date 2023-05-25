using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using System.Xml.Linq;
using POE;
using static System.Formats.Asn1.AsnWriter;
using static POE.Recipe;

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
        public int foodGroup { get; set; }


        public Ingredient(string ingrediants, double quantity, string unit, int calories, int foodGrp)
        {
            //recipename = recname;
            ingrediant = ingrediants;
            quantities = quantity;
            units = unit;
            Quantity = quantity;
            Calories = calories;
            foodGroup = foodGrp;
        }


    }
    class Recipe
    {
        public string recipeName { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<string> Steps { get; set; }



        public Recipe(string recname)
        {
            recipeName = recname;
            Ingredients = new List<Ingredient>();
            Steps = new List<string>();


        }

        public delegate void Calorie(string text);

        public static void caloiresExceeded(string text) => Console.WriteLine(text.ToUpper());
        public static void caloiresEnough(string text) => Console.WriteLine(text.ToUpper());


    }
    class recipeBook
    {
        public List<Recipe> recipes;

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

        private recipeBook recipebook = new recipeBook();
        Recipe recipe = new Recipe(recname);
        private static string recname;

        // Prompt user for recipe details
        public void newRecipe()
        {
            try
            {
                Console.WriteLine("Enter the name of recipe:");
                string recipeName = Console.ReadLine();

                Recipe recipe = new Recipe(recipeName);


                Console.WriteLine("Enter the number of ingredients:");

                int numIngredients = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < numIngredients; i++)
                {
                    Console.WriteLine("Enter the name of ingredient " + $"{i + 1} :");
                    String ingrediants = Console.ReadLine();



                    Console.WriteLine("Enter the quantity of ingredient " + $"{ingrediants}:");
                    double quantities = Convert.ToDouble(Console.ReadLine());



                    Console.WriteLine("Enter the unit of measurement for ingredient " + $"{ingrediants}:");
                    String units = Console.ReadLine();

                    Console.WriteLine($"Enter the calories for ingredient {ingrediants} :");
                    int calories = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Select food group for ingredient {i + 1} to be stored:" +
                        "\n1. Starchy foods " +
                        "\n2. Vegetables and fruits" +
                        "\n3. Dry beans, peas, lentils and soya " +
                        "\n4. Chicken, fish, meat and eggs" +
                        "\n5. Milk and dairy products " +
                        "\n6. Fats and oil" +
                        "\n7. Water ");
                    int foodGrp = Convert.ToInt32(Console.ReadLine());
                    switch (foodGrp)
                    {
                        case 1:
                            Console.WriteLine($"Ingredient {ingrediants} was added to Starchy foods");
                            break;
                        case 2:
                            Console.WriteLine($"Ingredient {ingrediants} was added to the food group Vegetables and fruits");
                            break;
                        case 3:
                            Console.WriteLine($"Ingredient {ingrediants} was added to the food group Dry beans, peas, lentils and soya");
                            break;
                        case 4:
                            Console.WriteLine($"Ingredient {ingrediants} was added to the food group Chicken, fish, meat and eggs");
                            break;
                        case 5:
                            Console.WriteLine($"Ingredient {ingrediants} was added to the food group Milk and dairy products");
                            break;
                        case 6:
                            Console.WriteLine($"Ingredient {ingrediants} was added to the food group Fats and oil");
                            break;
                        case 7:
                            Console.WriteLine($"Ingredient {ingrediants} was added to the food group Water");
                            break;

                    }


                    recipe.Ingredients.Add(new Ingredient(ingrediants, quantities, units, calories, foodGrp));

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
                Console.WriteLine($"Recipe {recipeName} wass added");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Option try again");
            }
        }

        //Displays the recipe names and prompt the user to type a name to display the details of the recipe
        public void Display()
        {
            try
            {
                ConsoleColor prevColour = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nList of recipes");
                Console.ForegroundColor = prevColour;
                ConsoleColor prevColour1 = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                recipebook.GetRecipeList().Sort((s1, s2) => s1.recipeName.CompareTo(s2.recipeName));
                foreach (var recipe in recipebook.GetRecipeList())

                {
                    Console.WriteLine(recipe.recipeName);
                }
                Console.ForegroundColor = prevColour1;

                Console.WriteLine("\nEnter a recipe name to view ingredients");
                string name = Console.ReadLine();


                recipe = recipebook.GetRecipeByName(name);

                if (name != null)
                {
                    Console.WriteLine($"\nRecipe {name}");

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
                    calorieCalculators cc = new calorieCalculators();
                    cc.calorieCalculator();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Recipe not found please try again");
            }


        }

        // method to half double or triple a recipe 
        public void Scaling()
        {
            try
            {
                Console.WriteLine("\nEnter a recipe name to scale the ingredients");
                string name = Console.ReadLine();


                recipe = recipebook.GetRecipeByName(name);

                if (name != null)
                {
                    double factor;

                    Console.WriteLine("\nEnter the scale factor (0.5, 2, or 3): ");
                    factor = Convert.ToDouble(Console.ReadLine());

                    foreach (var ingredient in recipe.Ingredients)
                    {
                        ingredient.quantities *= factor;
                    }
                    Console.WriteLine($"Recipe {name} scaled successfully!");
                }
                else
                {
                    Console.WriteLine($"Recipe with the name {name} not found!");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Recipe not found please try again");
            }
        }

        //Method to reset the recipe that is chosen
        public void Reset()
        {
            try
            {
                Console.WriteLine("\nEnter a recipe name to scale the ingredients");
                string name = Console.ReadLine();


                recipe = recipebook.GetRecipeByName(name);

                if (name != null)
                {
                    foreach (var ingredient in recipe.Ingredients)
                    {

                        ingredient.quantities = ingredient.Quantity;
                    }
                    Console.WriteLine("Recipe quantities reset successfully!");

                }
                else
                {
                    Console.WriteLine($"Recipe with the name {name} not found!");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Recipe not found please try again");
            }
        }

        // removes all recipes stored
        public void Clear()
        {
            Console.WriteLine("Are you sure you want to clear all data? (Y/N)");
            string ch = Console.ReadLine().ToUpper();
            if (ch == "Y")
            {
                recipe.Ingredients.Clear();
                Console.WriteLine("All data has been cleared.");
            }
            else
            {
                Console.WriteLine("Operation cancelled.");
            }

        }

       

    }
}
