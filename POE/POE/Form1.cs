namespace POE
{
    public partial class Form1 : Form
    {
        // create a new list thats stores all the ingredients under a specific name typed by the user

        private List<Recipes> recipes;
        public Form1()
        {
            InitializeComponent();
            recipes = new List<Recipes>();
        }
        
        //Button to take the user to add a new recipe
        private void AddRecipe_button_Click(object sender, EventArgs e)
        {
            try
            {
                AddRecipes AR = new AddRecipes();
                AR.RecipeAdded += AddRecipeForm_RecipeAdded;
                AR.Show();
            }catch(Exception ex) { }
        }

        private void AddRecipeForm_RecipeAdded(Recipes recipe)
        {
            recipes.Add(recipe);
        }
        //button to display the stored recipes
        private void Display_button_Click(object sender, EventArgs e)
        {
            try
            {



                DisplayForm DR = new DisplayForm(recipes);
                DR.Show();
            }catch(Exception ex) { }
        }
    }
}
