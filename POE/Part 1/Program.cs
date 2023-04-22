using POE;
using System;
internal class Program
{
    //Calling the main method
    private static void Main(string[] args)
    {
        int cl = 4;

        //declare an object in main or from outside the class
        Recipe recipe = new Recipe();

        //Calling the display method from recipe
        recipe.Display();

        // Do while loop to run until the user selcets the number to quit
        do
        {

            // Switch case to promp the user to select what to do from the list 
            Console.WriteLine("\nPress \n1 to Scale the recipe:\n2 to reset the recipe,\n3 to clear the recipe,\n4 to exit");
            cl = Convert.ToInt32(Console.ReadLine());


            switch (cl)
            {
                case 1:
                    //Calling the scaling method from recipe
                    recipe.Scaling();
                    break;

                case 2:
                    //Calling the reset method from recipe
                    recipe.Reset();
                    break;

                case 3:
                    //Calling the clear method from recipe
                    recipe.Clear();
                    break;

                case 4:

                    Console.WriteLine("Thank You");
                    break;
            }

        } while (cl != 4);
    }
}


