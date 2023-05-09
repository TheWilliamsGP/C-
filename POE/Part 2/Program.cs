namespace POE;
using System;
internal class Program
{

    //Calling the main method
    private static void Main(string[] args)
    {

        int cl = 6;

        //declare an object in main or from outside the class
        Recipes recipe = new Recipes();


        Console.WriteLine("Welcome to the recipe book");

        // Do while loop to run until the user selcets the number to quit
        do
        {

            // Switch case to promp the user to select what to do from the list 
            Console.WriteLine("\nPress \n1. to Add a new recipe \n2. to display the recipe \n3. to Scale the recipe \n4. to reset the recipe \n5. to clear the recipe \n6. to exit");
            cl = Convert.ToInt32(Console.ReadLine());


            switch (cl)
            {
                case 1:
                    //adding a reipce
                    recipe.newRecipe();
                    break;

                case 2:
                    //Calling the display method from recipe
                    recipe.Display();
                    break;

                case 3:
                    //Calling the scaling method from recipe
                    recipe.Scaling();
                    break;

                case 4:
                    //Calling the reset method from recipe
                    recipe.Reset();
                    break;

                case 5:
                    //Calling the clear method from recipe
                    recipe.Clear();
                    break;


                case 6:
                    Console.WriteLine("Thank You");
                    break;
            }

        } while (cl != 6);
    }
}


