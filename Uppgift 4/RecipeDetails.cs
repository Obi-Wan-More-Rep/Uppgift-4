using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_4
{
    public partial class RecipeDetails : Form
    {
        private Recipe selectedRecipe { get; set; }
        public Recipe UppdatedRecipe { get; set; }
        private bool isAdminSignedIn { get; set; }
        public bool DeleteRecipe { get; private set; }
        public bool AddRecipe { get; private set; }

        public RecipeDetails()
        {
            InitializeComponent();
        }

        private void StandardUserInterfaceSettings() // Vanessa
        {

        }

        private void AddNewRecipeUserInterfaceSettings() //Cornelia
        {

        }

    }
}
