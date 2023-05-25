﻿
using System;
using POE;
using System.Numerics;


namespace POE;
internal class Program
{

    //Calling the main method
    private static void Main(string[] args)
    {

        int cl = 6;

        //declare an object in main or from outside the class
        //Displays d = new Displays();
        //addRecipe addRec = new addRecipe();

        Recipes1 recipes = new Recipes1(); 

        Console.WriteLine("Welcome to the recipe book");

        // Do while loop to run until the user selcets the number to quit
        do
        {

            // Switch case to promp the user to select what to do from the list 
            Console.WriteLine("\nPress \n1. to Add a new recipe \n2. to display the recipe \n3. to Scale the recipe \n4. to reset the recipe \n5. to clear all data \n6. to exit");
            cl = Convert.ToInt32(Console.ReadLine());


            switch (cl)
            {
                case 1:
                    //adding a reipce
                    recipes.newRecipe();
                    
                    break;

                case 2:
                    //Calling the display method from recipe
                    recipes.Display();
                    break;

                case 3:
                    //Calling the scaling method from recipe
                    recipes.Scaling();
                    break;

                case 4:
                    //Calling the reset method from recipe
                    recipes.Reset();
                    break;

                case 5:
                    //Calling the clear method from recipe
                    recipes.Clear();
                    break;


                case 6:
                    Console.WriteLine("Thank You");
                    break;
            }

        } while (cl != 6);
    }
}

