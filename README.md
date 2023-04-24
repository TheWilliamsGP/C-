
# Recipe Storage system

Recipe Storage system is console app to store values in arrays using visual studio.

![GitHub last commit](https://img.shields.io/github/last-commit/TheWilliamsGP/C-)

### Usage

Use Visual Studio to run the code found on [Github](https://github.com/TheWilliamsGP/C-/tree/main/POE) 



## Description

```C#```

The program will ask a series of questions that needs to be answered in order to create a storage system for capture recipes in arrays.
The first question you will be prompted with is indicate the amount of ingredients that you would like to enter for this recipe which runs in a for loop depending on how many ingredients you would like to enter.
The follow up questions will be asked for you to type in ingredients names followed by the quantity and the unit it is measured in. 
Once all the ingredients are capture in the system the programs will then ask how many steps you are required to make the recipe and a follow questions will be asked to type in detail how to create the recipe step by step. 

Once the program has all the necessary data the program would display the the list of ingredients as well as the steps in a neat order.
This code runs in the Display() method.

You will then be prompted with a question asking if the recipe should be scaled, reset, clear or exit the program.

These are differet methods to the program will execute on selection.

Scaling() the scaling method would allow you to either half, double or triple the quantities of the ingredients that was stored in the the arrays.

The Reset() allows the user to restore the ingredients quantities back to the original value.

The Clear() would remove the data that was captured and would then ask if a new recipe should be entered or return the menu. The clear menu will prompt to confirm to clear all the data with a if statment.

The last option is to close the whole program.

These methods run in a class Called Recipe which is made an object and methods are called into the main class. The scaled, reset, clear or exit are using switch statements to select the option on which method to call.

Note: I implemented "using system;" in order for the code to run on Windows as well as MacOS

showing the display method 



    using POE;
    using System;
    internal class Program
    {
    //Calling the main method
    private static void Main(string[] args)
    {
        int ch = 4;

        //declare an object in main or from outside the class
        Recipe recipe = new Recipe();

        //Calling the display method from recipe
        recipe.Display();

        // Do while loop to run until the user selcets the number to quit
        do
        {
            
            // Switch case to promp the user to select what to do from the list 
            Console.WriteLine("\nPress \n1 to Scale the recipe:\n2 to reset the recipe,\n3 to clearthe recipe,\n4 to exit");
            ch = Convert.ToInt32(Console.ReadLine());

           
            switch (ch)
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

        } while (ch != 4);
    }
}

## Screenshots
 The screenshot shows the finished display() method in the terminal  
![Display output](https://drive.google.com/uc?id=1knJG8yP6waJ-QmIx5S3R8mP_STt1tLg8)


Repsitory history 
![Repo Hisory](https://drive.google.com/uc?id=1ZAeZQgMm4f1WzTALdRfGro4cQ8g8dXz2)
