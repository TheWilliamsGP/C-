using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;
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

        public Ingredient(string recname,string ingrediants, double quantity, string unit)
        {
            recipename = recname;
            ingrediant = ingrediants;
            quantities = quantity;
            units = unit;
            defaultQuantity = quantity;
        }
    }
        class Recipe
        {
            public List<Ingredient> Ingredients { get; set; }
            public List<string> Steps { get; set; }

            public Recipe()
            {
                Ingredients = new List<Ingredient>();
                Steps = new List<string>();
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


                    rec.Ingredients.Add(new Ingredient(recipename,ingrediants, quantities, units));

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
            foreach (var ingredient in rec.Ingredients)
            {
                Console.WriteLine("Recipe Name: "+$"{ingredient.recipename}");
            }
            Console.WriteLine("________________________________\nIngredients:\n________________________________");
            foreach (var ingredient in rec.Ingredients) 
                {
                
                    Console.WriteLine($"{ingredient.quantities} {ingredient.units} of {ingredient.ingrediant}");
                }

            Console.WriteLine("________________________________\nSteps:\n________________________________");
            for (int i = 0; i < rec.Steps.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {rec.Steps[i]}");
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


        }
        }
    }


