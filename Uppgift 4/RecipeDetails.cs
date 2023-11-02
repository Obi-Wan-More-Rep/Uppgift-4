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
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace Uppgift_4
{
    public partial class RecipeDetails : Form
    {
        private Recipe selectedRecipe { get; set; }
        public Recipe UppdatedOrAddedRecipe { get; set; }
        private bool isAdminSignedIn { get; set; }
        public bool DeleteRecipe { get; private set; }
        public bool AddRecipe { get; private set; }
        public DataHandler DataHandler { get; set; }

        // Om du klickar på ett recept i MainForm
        public RecipeDetails(bool isAdminSignedIn, Recipe selectedRecipe) //Kevin
        {
            InitializeComponent();
            this.isAdminSignedIn = isAdminSignedIn;
            UppdatedOrAddedRecipe = new Recipe { Title = selectedRecipe.Title, Type = selectedRecipe.Type, PiImage = selectedRecipe.PiImage, RecipeID = selectedRecipe.RecipeID, Description = selectedRecipe.Description };
            this.selectedRecipe = selectedRecipe;
            StandardUserInterfaceSettings();
        }

        // Om du klickar på AddNewRecipe knappen i MainForm
        public RecipeDetails(bool isAdminSignedIn, DataHandler dataHandler) // Kevin
        {
            InitializeComponent();
            this.isAdminSignedIn = isAdminSignedIn;
            this.selectedRecipe = new Recipe();
            this.DataHandler = dataHandler;
            AddNewRecipeUserInterfaceSettings();
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
            if (File.Exists(selectedRecipe.PiImage))
            {
                Image image = Image.FromFile(selectedRecipe.PiImage);
                pictureBox1.Image = image;
            }

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
        private void richTxtDescription_DoubleClick(object sender, EventArgs e)
        {
            if (isAdminSignedIn)
            {
                richTxtDescription.ReadOnly = !richTxtDescription.ReadOnly;

                if (richTxtDescription.BackColor == this.BackColor)
                {
                    richTxtDescription.BackColor = Color.White;
                }
                else
                {
                    richTxtDescription.BackColor = this.BackColor;
                }
            }
        }

        // Lägg till ett recept
        private void buttonAddRecipe_Click(object sender, EventArgs e) //Cornelia
        {
            // Skapa ett nytt recept ID
            string newRecipeID = RecipeIDGenerator();

            AddRecipe = true;
            UppdatedOrAddedRecipe = new Recipe
            {
                Title = textBoxTitle.Text,
                Type = textBoxType.Text,
                PiImage = "",           // Kan lägga till en combobox/textbox i Form designen där man kan antingen välja vilken bild att använda sig av eller skriva in filsökvägen på en bild som finns på datorn.
                RecipeID = newRecipeID,
                Description = String.Join(@"\n", richTxtDescription.Lines)
            };
            this.Close();
        }

        // Ta bort ett recept
        private void buttonDeleteRecipe_Click(object sender, EventArgs e) // Kevin
        {
            DeleteRecipe = true;
            this.Close();
        }

        // Uppdatera ett recept
        private void buttonUpdateRecipe_Click(object sender, EventArgs e) // Kevin
        {
            UppdatedOrAddedRecipe = new Recipe
            {
                Title = textBoxTitle.Text,
                Type = textBoxType.Text,
                PiImage = selectedRecipe.PiImage, // Kan lägga till en combobox/textbox där man kan antingen välja vilken bild att använda sig av eller skriva in filsökvägen som finns på datorn.
                RecipeID = selectedRecipe.RecipeID,
                Description = string.Join(@"\n", richTxtDescription.Lines)
            };
            this.Close();
        }

        private string RecipeIDGenerator() // Kevin
        {
            List<Recipe> recipes = DataHandler.recipes; // Importera recept listan
            

            Random random = new Random(); // Skapa en ny random
            
            while (true) // Loopa denna kod tills datorn hittar ett tal/ID som inte redan existerar i något recept
            {
                string randomNumber = random.Next(1000, 9999).ToString();
                Recipe DoesIDAlreadyExist = DataHandler.recipes.FirstOrDefault(recipe => recipe.RecipeID == randomNumber);

                if (DoesIDAlreadyExist == null)
                {
                    return randomNumber;
                }
            }
        }
    }
}
