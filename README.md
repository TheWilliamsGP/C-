
# Recipe Storage system

Recipe Storage system is console app to store recipes with ingredients in lists using visual studio.

![GitHub last commit](https://img.shields.io/github/last-commit/TheWilliamsGP/C-)

### Usage

Use Visual Studio to run the code found on [Github](https://github.com/TheWilliamsGP/C-/tree/main/POE) 

## Version 2.0

FOOD GROUPS
 The user is asked to select a food group the ingredint blomgs to and each food group has a description on what benifits it has and some has examples of the type of ingreidient that belong to the food group.

CALORIES
The user is required to enter the amount of calories each ingredient has which will be stored in a list.

Calorie Calulator
The calories that was stored in the list will be calculated and to find the total amount and with the use of delegates the user will be notified if the total amount of calories exceed 300.

Patch notes
exceptions was added if the user enters invalid options and take the user back to the main method.

## Description


```C#```

The program will ask a series of questions that needs to be answered in order to create a storage system for capture recipes with ingredients in lists.
The first question you will be prompted with is indicate name of the reciepe followed by the amount of ingredients that you would like to enter for this recipe which runs in a for loop depending on how many ingredients you would like to enter. 
The follow up questions will be asked for you to type in ingredients names followed by the quantity and the unit it is measured in followed to seldct a food group they belong as well as the amount of calories the ingredient has.
Once all the ingredients are capture in the system the programs will then ask how many steps you are required to make the recipe and a follow questions will be asked to type in detail how to create the recipe step by step. 

This code runs in the newRecipe() method.

A menu will display to prompt the user to either add newRecipe(), Display(), Scalling(), Rest() and Clear().

These are differet methods to the program will execute on selection.
 
 The newRecipe() allows the user to enter andother recipe thats stored in a list and the user will be able to store unlimited amount of recipes.

Display() allows the user to select which recipe to diplay from the list that was stored by tyrping in the name, to show all the ingredients with quantities and calories. The calories will tally up and display a message if the calories exceed 300.

Scaling() the scaling method would allow you to either half, double or triple the quantities of the ingredients that was stored in the the arrays.

The Reset() allows the user to restore the ingredients quantities back to the original value.

The Clear() would remove the data that was captured and would then ask if a new recipe should be entered or return the menu. The clear menu will prompt to confirm to clear all the data with a if statment.

The last option is to close the whole program.

These methods run in a class Called Recipe which is made an object and methods are called into the main class. The add recipe, display, scaled, reset, clear or exit are using switch statements to select the option on which method to call.

Note: I implemented "using system;" in order for the code to run on Windows as well as MacOS

showing the display method 



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


## Screenshots

 The screenshot shows the updated display() method in the terminal  
![Display output](https://drive.google.com/uc?id=11U56ScOsjnNYx9c-Q5-3rhSopEURprsN6)

Repository History
![Repo Hisory](https://drive.google.com/uc?id=1ZAeZQgMm4f1WzTALdRfGro4cQ8g8dXz2)


