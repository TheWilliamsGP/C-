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
    public partial class AddRecipes : Form
    {
        public event Action<Recipes> RecipeAdded;
        public AddRecipes()
        {
            InitializeComponent();
        }
        //button to save the recipe name 
        private void Save_button_Click(object sender, EventArgs e)
        {
            try
            {


                string recipeName = RecipeName_textBox.Text;
                Recipes recipe = new Recipes() { recipename = recipeName };
                RecipeAdded?.Invoke(recipe);
                MessageBox.Show("Recipe Name successfully stored", "Added", MessageBoxButtons.OK);

                IngredientForm ingredientForm = new IngredientForm(recipe);
                ingredientForm.Show();

                Close();
            }
            catch
            {
                MessageBox.Show("Error! please fill in the correct fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
