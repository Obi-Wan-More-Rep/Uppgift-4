using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        public Recipe AddOrUppdateRecipe { get; set; }
        private bool isAdminSignedIn { get; set; }
        public bool DeleteRecipe { get; private set; }
        public bool AddRecipe { get; private set; }
        public DataHandler DataHandler { get; set; } 

        // Om du klickar på ett recept i MainForm
        public RecipeDetails(bool isAdminSignedIn, Recipe selectedRecipe) //Kevin
        {
            InitializeComponent();
            this.isAdminSignedIn = isAdminSignedIn;
            AddOrUppdateRecipe = new Recipe { Title = selectedRecipe.Title, Type = selectedRecipe.Type, PiImage = selectedRecipe.PiImage, RecipeID = selectedRecipe.RecipeID, Description = selectedRecipe.Description };
            this.selectedRecipe = selectedRecipe;
            StandardUserInterfaceSettings();
            LoadPicturesToComboBox();
        }

        // Om du klickar på AddNewRecipe knappen i MainForm
        public RecipeDetails(bool isAdminSignedIn, DataHandler dataHandler) // Kevin
        {
            InitializeComponent();
            this.isAdminSignedIn = isAdminSignedIn;
            AddOrUppdateRecipe = new Recipe();
            this.DataHandler = dataHandler;
            AddNewRecipeUserInterfaceSettings();
            LoadPicturesToComboBox();
        }

        private void StandardUserInterfaceSettings() // Vanessa
        {
            if (isAdminSignedIn) //kolla om admin är inloggad
            {
                buttonUpdateRecipe.Visible = true;
                buttonDeleteRecipe.Visible = true;
                comboBoxImages.Visible = true;
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
            comboBoxImages.Visible = true;

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

            AddOrUppdateRecipe.Title = textBoxTitle.Text;
            AddOrUppdateRecipe.Type = textBoxType.Text;
            AddOrUppdateRecipe.RecipeID = newRecipeID;
            AddOrUppdateRecipe.Description = String.Join(@"\n", richTxtDescription.Lines);

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
            AddOrUppdateRecipe.Title = textBoxTitle.Text;
            AddOrUppdateRecipe.Type = textBoxType.Text;
            //AddOrUppdateRecipe.PiImage = selectedRecipe.PiImage;
            AddOrUppdateRecipe.RecipeID = selectedRecipe.RecipeID;
            AddOrUppdateRecipe.Description = string.Join(@"\n", richTxtDescription.Lines);
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

        // Lägg till alla möjliga bilder att välja från i ComboBox listan
        public void LoadPicturesToComboBox()
        {
            string imagesMapFilePath = @"../../../Bilder";

            // Spara alla filsökvägar för bilder som finns under "Bilder" mappen i en array.
            string[] jpgImagesFilePath = Directory.GetFiles(imagesMapFilePath, "*.jpg");
            string[] jpegImagesFilepath = Directory.GetFiles(imagesMapFilePath, "*.jpeg");
            // Har ingen bättre lösning än att ha två arrays för varsin fil extention och kombinera till en ända.
            string[] imagesFilePath = jpgImagesFilePath.Concat(jpegImagesFilepath).ToArray();

            foreach (string imageFilePath in imagesFilePath)
            {
                comboBoxImages.Items.Add(Path.GetFileName(imageFilePath)); // slipper använda substring för att ta bort "../../../Bilder"
                Debug.WriteLine(imageFilePath);
            }
        }

        // När du byter bild i Combobox
        private void comboBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedImageFileName = comboBoxImages.SelectedItem.ToString();
            string ImageFilePath = @$"../../../Bilder/{selectedImageFileName}";
            AddOrUppdateRecipe.PiImage = ImageFilePath; // ser inte så fint ut. Detta bör vara i "buttonUpdateRecipe_Click()" metoden

            if (File.Exists(ImageFilePath))
            {
                Image image = Image.FromFile(ImageFilePath);
                pictureBox1.Image = image;
            }
        }
    }
}
