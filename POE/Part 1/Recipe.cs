using System;
namespace POE
{
    public class Recipe
    {
        // Initialise recipe variables
        int numIngredients = 0;
        int numSteps = 0;
        string[] ingredients; //Array to store ingredient names
        double[] quantities; //Array to store ingredient quantities
        string[] units;     //Array to store ingredient units
        string[] steps;    //Array to store step descriptions
        double[] quantity;
        double q;
        public void Display()
        {

            // Prompt user for recipe details
            Console.WriteLine("Enter the number of ingredients:");

            numIngredients = Convert.ToInt32(Console.ReadLine());
            ingredients = new string[numIngredients];
            quantities = new double[numIngredients];
            units = new string[numIngredients];
            quantity = new double[numIngredients];


            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine("Enter the name of ingredient " + $"{i + 1} :");

                ingredients[i] = Console.ReadLine();

                Console.WriteLine("Enter the quantity of ingredient " + $"{i + 1}:");
                q = Convert.ToDouble(Console.ReadLine());
                quantities[i] = q;
                quantity[i] = quantities[i];


                Console.WriteLine("Enter the unit of measurement for ingredient " + $"{i + 1}:");
                units[i] = Console.ReadLine();
            }

            Console.WriteLine("Enter the number of steps:");
            numSteps = Convert.ToInt32(Console.ReadLine());
            steps = new string[numSteps];

            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine("Enter the description of step " + $"{i + 1}:");
                steps[i] = Console.ReadLine();
            }

            // Display the recipe
            Console.WriteLine("\nIngredients:\n________________________________");
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"{i + 1}" + ". " + quantities[i] + " " + units[i] + " " + ingredients[i]);
            }
            Console.WriteLine("________________________________\nSteps:\n________________________________");
            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"{i + 1}" + ". " + steps[i]);
            }

        }


        //Prompt the user to either double half triple the recipe
        public void Scalling()

        {
            double Factor;


            Console.WriteLine("\nEnter the scale factor (0.5, 2, or 3): ");
            Factor = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < numIngredients; i++)
            {
                quantity[i] *= Factor;
            }

            Console.WriteLine("\nScaled recipe:");
            Console.WriteLine("______________________________\nIngredients:\n________________________________");
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"{i + 1}" + ". " + quantity[i] + " " + units[i] + " " + ingredients[i]);
            }

            Console.WriteLine("________________________________\nSteps:\n________________________________");
            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"{i + 1}" + ". " + steps[i]);
            }

        }

        // resets the recipe quantities to the original input
        public void Reset()
        {

            Console.WriteLine("\nOriginal recipe:\n________________________________");

            for (int i = 0; i < numIngredients; i++)
            {

                Console.WriteLine(quantities[i] + units[i] + " " + ingredients[i]);


            }
            Console.WriteLine("________________________________\nSteps:\n________________________________");
            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"{i + 1}" + ". " + steps[i]);
            }
        }

        //Allows the user to clear all the data stored in the arrays
        public void Clear()
        {

            ingredients = new string[0];
            quantities = new double[0];
            units = new string[0];
            steps = new string[0];

            Console.WriteLine("\nAll data cleared press 1 to enter a new recipe or 2 to return to menu:");
            int scaleOption = Convert.ToInt32(Console.ReadLine());

            if (scaleOption == 1)
            {
                Display();
            }
            else Console.WriteLine("Returning to menu");
        }

    }

}




