using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Uppgift_4
{
    public partial class RecipeDetails : Form
    {
        private Recipe selectedRecipe { get; set; }
        public Recipe UppdatedRecipe { get; set; }
        private bool isAdminSignedIn { get; set; }
        public bool DeleteRecipe { get; private set; }
        public bool AddRecipe { get; private set; }

        public RecipeDetails() //Kevin
        {
            InitializeComponent();
            AddNewRecipeUserInterfaceSettings();//Vanessa la till denna för att testa
        }

        private void StandardUserInterfaceSettings() // Vanessa
        {
            if (isAdminSignedIn) //kolla om admin är inloggad
            {
                buttonUpdateRecipe.Visible = true;
                buttonDeleteRecipe.Visible = true;
            }
            //labels ser mindre ut som labels
            textBoxTitle.BorderStyle = BorderStyle.None;
            textBoxType.BorderStyle = BorderStyle.None;
            richTxtDescription.BorderStyle = BorderStyle.None;
            //samma färg på backcolor som bakrunden av formen
            textBoxTitle.BackColor = this.BackColor;
            textBoxType.BackColor = this.BackColor;
            richTxtDescription.BackColor = this.BackColor;
            //populera textrutorna med receptet
            textBoxTitle.Text = selectedRecipe.Title;
            textBoxType.Text = selectedRecipe.Type;
            //hanterar rich textbox för att visa flera rader korrekt
            richTxtDescription.Lines = selectedRecipe.Description.Split(@"\n");
        }

        private void AddNewRecipeUserInterfaceSettings()
        {
            //ger tillgång till att ändra texten i textrutorna
            textBoxTitle.ReadOnly = false;
            textBoxType.ReadOnly = false;
            richTxtDescription.ReadOnly = false;

            buttonAddRecipe.Visible = true;

            //AVVAKTA MED DENNA kolla på alt
            textBoxTitle.BorderStyle = BorderStyle.None;
            textBoxType.BorderStyle = BorderStyle.None;
            richTxtDescription.BorderStyle = BorderStyle.None;
        }

        private void TextBox_DoubleClick(object sender, EventArgs e)//Vanessa har tillfällig prov period på denna
        {
            if (isAdminSignedIn)
            {
                TextBox textBox = sender as TextBox;
                if (textBox != null)
                {
                    textBox.ReadOnly = !textBox.ReadOnly;

                    if (textBox.BackColor == this.BackColor)
                    {
                        textBox.BackColor = Color.White;
                    }
                    else
                    {
                        textBox.BackColor = this.BackColor;
                    }
                }
            }
        }

        private void buttonAddRecipe_Click(object sender, EventArgs e) //Cornelia
        {
            AddRecipe = true;
            UppdatedRecipe = new Recipe
            {
                Title = textBoxTitle.Text,
                Type = textBoxType.Text,
                Description = String.Join(@"\n", richTxtDescription.Lines)
            };
            //Stänger formen efter den sparat 
            this.Close();
        }

        private void buttonDeleteRecipe_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdateRecipe_Click(object sender, EventArgs e)
        {

        }
    }
}
