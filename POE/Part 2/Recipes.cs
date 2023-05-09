using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace POE

{
    public class Ingredients
    {
        public string recipeName { get; set; }
        public double myquantities { get; set; }
        public string myunits { get; set; }
    }

    //class Recipe {
    //    List<Ingredients> ingredients = new List<Ingredients>();
    //}
    //public class Recipe
    //{

    //    private List<string> ingredients = new List<string>();

    //    public List<string> recipeName
    //    {
    //        get { return recipeName; }
    //        set { recipeName = value; }

    //        get { return myquantities; }
    //        set { myquantities = value; }

    //    }
    //    private List<string> steps = new List<string>();

    //}


    //class Ingredients
    //{
    //    public string recipeName { get; set; }
    //    public double myquantities { get; set; }
    //    public string myunits { get; set; }

    //}

    //class Step
    //{
    //    public string mySteps { get; set; }
    //}
    //class Recipes
    //{
    //    // Initialise recipe variables


    // int numIngredients = 0;
    //int numSteps = 0;
    //public string recipeName { get; set; }
    //List<Ingredients> myingredients = new List<Ingredients>();
    //List<Step> mysteps = new List<Step>();
    //public Recipes(string name, List<Ingredients> myingredient, List<Step> steps)
    //{
    //    recipeName = name;
    //    myingredients = myingredient;
    //    mysteps = steps;
    //}


    //class Recipebook
    //{
    //    private List<Recipes> recipes;

    //    public Recipebook()
    //    {
    //        recipes = new List<Recipes>();
    //    }
    //    public void newRecipe(Recipes recipe)
    //    {
    //        recipes.Add(recipe);

    //    }

    //    public void RemoveRecipe(Recipes recipe)
    //    {
    //        recipes.Remove(recipe);
    //    }
    //    public List<Recipes> GetRecipes()
    //    {
    //        return recipes;
    //    }
    //    public Recipes GetRecipesByName(string name)
    //    {
    //        foreach (Recipes recipes in recipes)
    //        {
    //            if (recipes.recipeName == name)
    //            {
    //                return recipes;
    //            }
    //        }
    //        return null;
    //    }
    //}


    //}
    //class book
    //{
    //    private Recipebook recipebook;
    //}
    //public book()
    //{
    //    recipebook = new recipeBook();
    //}
    public void newRecipe()
        {
       
    
    // Console.WriteLine("Enter the number of Recipes to enter:");
    //int numRecipe = Convert.ToInt32(Console.ReadLine());
    // for (int j = 0; j <numRecipe; j++)


    Console.WriteLine("Enter the name of recipe:");
                string recipeName = Console.ReadLine();
      
      

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


            ingredients.Add(new Ingredients { myquantities = quantities, myunits = units });
                }
                Console.WriteLine("Enter the number of steps:");
               int numSteps = Convert.ToInt32(Console.ReadLine());



                for (int i = 0; i < numSteps; i++)
                {
                    Console.WriteLine("Enter the description of step " + $"{i + 1}:");
                    string mysteps = Console.ReadLine();
                
                }
            }
        
        public void Display()
{
            Console.WriteLine("________________________________");
            for (int i = 0; i < numRecipe; i++)
            {
                Console.WriteLine($"{i + 1}" + ". " + myRecipe[i]);
            }
            // Display the recipe that was stored
             Console.WriteLine("\nIngredients:\n________________________________");
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"{i + 1}" + ". " + myquantities[i] + " " + myunits[i] + " " + myingredients[i]);
            }
            Console.WriteLine("________________________________\nSteps:\n________________________________");
            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"{i + 1}" + ". " + mysteps[i]);
            }

        }


        //Prompt the user to either double half triple the recipe
        public void Scaling()

        {
            double Factor;


            Console.WriteLine("\nEnter the scale factor (0.5, 2, or 3): ");
            Factor = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < numIngredients; i++)
            {
                myquantity[i] *= Factor;
            }

            Console.WriteLine("\nScaled recipe:");
            Console.WriteLine("______________________________\nIngredients:\n________________________________");
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"{i + 1}" + ". " + myquantity[i] + " " + myunits[i] + " " + myingredients[i]);
            }

            Console.WriteLine("________________________________\nSteps:\n________________________________");
            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"{i + 1}" + ". " + mysteps[i]);
            }

        }

        // resets the recipe quantities to the original input
        public void Reset()
        {

            Console.WriteLine("\nOriginal recipe:\n________________________________");

            for (int i = 0; i < numIngredients; i++)
            {

                Console.WriteLine(myquantities[i] + myunits[i] + " " + myingredients[i]);


            }
            Console.WriteLine("________________________________\nSteps:\n________________________________");
            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"{i + 1}" + ". " + mysteps[i]);
            }
        }

        //Allows the user to clear all the data stored in the arrays
        public void Clear()
        {

            string select;
            Console.WriteLine("Are you sure you want to clear the recipe y/n");
            select = Console.ReadLine();
            if (select == "y")
            {
                //Reset all arrays to equal nothing
                //ingredients = new string[0];
                //quantities = new double[0];
                //units = new string[0];
                //steps = new string[0];

                Console.WriteLine("\nAll data cleared press 1 to enter a new recipe or 2 to return to menu:");
                int scaleOption = Convert.ToInt32(Console.ReadLine());

                if (scaleOption == 1)
                {
                    Display();
                }
                else Console.WriteLine("Returning to menu");

            }
            else if (select == "n")
            {

                Console.WriteLine("Returing to the menu");


            }
        }

    }

}



