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


    public partial class StepsForm : Form
    {

        private Recipes recipe;
        public List<Steps> Step;
        public StepsForm(Recipes recipes)
        {
            InitializeComponent();
            this.recipe = recipes;
            Step = new List<Steps>();
            
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            try
            {
                //stores the steps in the list
                string step = StepstextBox.Text;
                Steps steps = new Steps(step);
                Step.Add(steps);
                MessageBox.Show("Steps added successfully", "Added", MessageBoxButtons.OK);
                StepstextBox.Text = "";
            }catch (Exception ex)
            {
                MessageBox.Show("Error! Please fill in the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            recipe.STEPS.AddRange(Step);
            Close();
        }
    }
}
