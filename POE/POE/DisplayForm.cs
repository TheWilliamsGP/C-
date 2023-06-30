using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POE
{
    public partial class DisplayForm : Form
    {
        private List<Recipes> recipes;
        public DisplayForm(List<Recipes> recipes)
        {
            InitializeComponent();
            this.recipes = recipes;
            DisplayRecipe();
        }
        // displays the full details of the recipes 
        private void DisplayRecipe()
        {
            try { 

            foreach (Recipes recipes in recipes)
            {

                //Displays the recipe details in a list box
                Display_listBox.Items.Add("Recipe name: " + recipes.recipename);
                Display_listBox.Items.Add("-------------------------------------");
                Display_listBox.Items.Add("Ingredient List:");
                Display_listBox.Items.Add("-------------------------------------");

                foreach (Ingredients ingredient in recipes.ingredients)
                {
                    string item = ($"{ingredient.quantities} {ingredient.units} of {ingredient.ingredient}, \n{ingredient.Calories} calories");
                    Display_listBox.Items.Add(item);
                }


                Display_listBox.Items.Add("-------------------------------------");
                Display_listBox.Items.Add("Steps:");

                foreach (Steps steP in recipes.STEPS) 
                {
                    string stepS = ($"{steP.step}");
                    Display_listBox.Items.Add(stepS); 
                }

                Display_listBox.Items.Add("-------------------------------------");


                int totalCalories = 0;

                foreach (Ingredients ingredient in recipes.ingredients)
                {

                    totalCalories += ingredient.Calories;

                    
                }
                Display_listBox.Items.Add($"\nTotal calories: {totalCalories}");
            }
            Display_listBox.Items.Add("-------------------------------------");
            }
            catch {
                MessageBox.Show("Warning please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // button will allow the user to filter the list to find a recipe
        private void Filter_button_Click(object sender, EventArgs e)
        {
            try
            {
                string ingredientFilter = ingredient_textbox.Text;
                string foodGroupFilter = FoodGroupComboBox.SelectedItem.ToString();
                int maxCaloriesFilter = int.Parse(CalorieFilter_textBox.Text);

                // Filter recines based on criteria
                List<Recipes> filteredRecipes = recipes.Where(recipe =>
                {

                    bool ingredientMatch = recipe.ingredients.Any(ingredient => ingredient.ingredient.Contains(ingredientFilter));
                    bool foodGroupMatch = string.IsNullOrEmpty(foodGroupFilter) || recipe.ingredients.Any(ingredient => ingredient.foodGroup == foodGroupFilter);
                    bool maxCaloriesMatch = recipe.ingredients.Sum(ingredient => ingredient.Calories) <= maxCaloriesFilter;
                    return ingredientMatch && foodGroupMatch && maxCaloriesMatch;
                }).ToList();

                //Display filtered recipes
                Display_listBox.Items.Clear();
                foreach (Recipes recipe in filteredRecipes)
                {
                    Display_listBox.Items.Add(recipe.recipename);
                    Display_listBox.Items.AddRange(recipe.ingredients.Select(ingredient => $"_ {ingredient.ingredient}").ToArray());
                }
            }
            catch
            {
                MessageBox.Show("Error please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
