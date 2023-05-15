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
        public double defaultQuantity { get; set; }
        public int Calories { get; set; }
        //public int TotalCalories { get; private set; }


        public Ingredient(string recname, string ingrediants, double quantity, string unit, int calories)
        {
            recipename = recname;
            ingrediant = ingrediants;
            quantities = quantity;
            units = unit;
            defaultQuantity = quantity;
            Calories = calories;
            
        }
    }

        class Recipe
        {
            public List<Ingredient> Ingredients { get; set; }
            public List<string> Steps { get; set; }
            // public int TotalCalories { get; private set; }
             

        public Recipe()
            {
                Ingredients = new List<Ingredient>();
                Steps = new List<string>();
                //TotalCalories = CalculateTotalCalories();
        }
           

        
    }
    internal class Recipes
    {
        Recipe rec = new Recipe();
        public void newRecipe()
        {


            Console.WriteLine("Enter the name of recipe:");
            string recipename = Console.ReadLine();



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


                rec.Ingredients.Add(new Ingredient(recipename, ingrediants, quantities, units, calories));

            }
            Console.WriteLine("Enter the number of steps:");
            int numSteps = Convert.ToInt32(Console.ReadLine());



            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine("Enter the description of step " + $"{i + 1}:");
                string steps = Console.ReadLine();
                rec.Steps.Add(steps);

            }
        }

        public void Display()
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            foreach (var ingredient in rec.Ingredients)
            {
                Console.WriteLine("Recipe Name: " + $"{ingredient.recipename}");
            }
            Console.ForegroundColor = prevColor;
            Console.WriteLine("________________________________\nIngredients:\n________________________________");
            foreach (var ingredient in rec.Ingredients)
            {

                Console.WriteLine($"{ingredient.quantities} {ingredient.units} of {ingredient.ingrediant}, {ingredient.Calories} calories");
            }

            Console.WriteLine("________________________________\nSteps:\n________________________________");
            for (int i = 0; i < rec.Steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {rec.Steps[i]}");
            }

            int totalCalories = 0;
            foreach (var ingredient in rec.Ingredients)
                {
                totalCalories += ingredient.Calories;
                }
            
            Console.WriteLine($"Total calories: {totalCalories}");

            if (totalCalories > 300)
            {
                Console.WriteLine("WARNING: Recipe exceeds 300 calories!");
            }else
            {
                Console.WriteLine("Recipe is healthy");
            }
        }
        public void Scaling()
        {
            double factor;

            Console.WriteLine("\nEnter the scale factor (0.5, 2, or 3): ");
            factor = Convert.ToDouble(Console.ReadLine());

            foreach (var ingredient in rec.Ingredients)
            {
                ingredient.quantities *= factor;
            }
        }

        public void Reset()
        {
            foreach (var ingredient in rec.Ingredients)
            {

                ingredient.quantities = ingredient.defaultQuantity;
            }
        }
        public void Clear()
        {

            rec.Ingredients.Clear();
        }
    }
}