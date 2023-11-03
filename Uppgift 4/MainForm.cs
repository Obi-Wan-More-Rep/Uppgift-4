using System.Diagnostics;
using System.Drawing.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace Uppgift_4
{
    public partial class MainForm : Form
    {
        private DataHandler dataHandler { get; set; } = new DataHandler();
        private bool isAdminSignedIn { get; set; }


        public MainForm()
        {
            InitializeComponent();
            LoadRecipesIntoDataGridView();

        }

        private void LoadRecipesIntoDataGridView()
        {
            List<Recipe> recipes = dataHandler.recipes; // f� en lista av recepten fr�n DataHandler klassen
            comboBox1.Items.Add("All types");
            foreach (Recipe recipe in recipes)
            {
                AddRecipesToDataGridView(recipe);

                // L�gg till typen/kategori i ComboBoxen om den redan inte finns.
                if (!comboBox1.Items.Contains(recipe.Type))
                {
                    comboBox1.Items.Add(recipe.Type);

                }
            }
        }

        // L�gg till recept till dataGridView
        private void AddRecipesToDataGridView(Recipe recipe)
        {
            if (File.Exists(recipe.PiImage))
            {
                Image image = Image.FromFile(recipe.PiImage);
                dataGridView.Rows.Add(recipe.Title, image, recipe.RecipeID);
            }
            else
            {
                dataGridView.Rows.Add(recipe.Title, null, recipe.RecipeID);
            }
        }

        // Ta bort knappen
        public void TaBort() // Simon
        {
            var index = dataGridView.SelectedCells[0];
            if (index != null)
                dataHandler.recipes.RemoveAt(index.RowIndex);
            dataGridView.Rows.RemoveAt(index.RowIndex);

            dataHandler.UpdateTextFile(); // Simon

        }



        // s�ka p� recept fr�n recipes listan och visa i DataGridView
        private void textBoxSearch_TextChanged(object sender, EventArgs e) // Najah
        {
            string searchText = textBoxSearch.Text.ToLower(); // vara inte k�nslig om  stora boksatver
            dataGridView.Rows.Clear();

            List<Recipe> recipes = dataHandler.recipes; 
            foreach (var recipe in recipes)
            {
                if (recipe.Title.ToLower().Contains(searchText) ||
                    recipe.Type.ToLower().Contains(searchText))

                {
                    AddRecipesToDataGridView(recipe);
                }
            }
        }

        // Skapa ett nytt recept
        private void buttonAdd_Click(object sender, EventArgs e) // Vanessa & Cornelia
        {
            RecipeDetails details = new RecipeDetails(isAdminSignedIn, dataHandler);
            details.ShowDialog();

            if (details.AddRecipe)
            {
                Recipe newRecipe = details.AddOrUppdateRecipe;
                // om man skrivit n�got p� det nya receptet kommer den skapa ett nytt recept
                if (newRecipe != null)
                {
                    // L�gg till ett nytt recept i listan och textfilen
                    dataHandler.AddRecipe(newRecipe);

                    // L�gg till receptet i dataGridView
                    AddRecipesToDataGridView(newRecipe);
                }
            }
        }


        private void buttonSignIn_Click(object sender, EventArgs e) // Kamal
        {
            FrmLogin frmLogin = new FrmLogin(dataHandler.admins);
            frmLogin.ShowDialog();
            isAdminSignedIn = frmLogin.IsLoginSuccessful;

            if (isAdminSignedIn)
            {
                buttonSignIn.Visible = false;
                buttonSignOut.Visible = true;
                buttonAdd.Visible = true;
                buttonDelete.Visible = true;
            }
        }

        private void buttonSignOut_Click(object sender, EventArgs e) // Kamal
        {
            isAdminSignedIn = false;
            buttonSignIn.Visible = true;
            buttonSignOut.Visible = false;
            buttonAdd.Visible = false;
            buttonDelete.Visible = false;
        }

        // Ta bort markerad recipe
        private void buttonDelete_Click(object sender, EventArgs e) // Simon
        {
            //Ta bort receptet fr�n listan och textfilen
            TaBort();
        }

        // ComboBox metod
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // Najah
        {
            List<Recipe> recipes = dataHandler.recipes;
            string selectedmatype = comboBox1.SelectedItem.ToString();
            if (selectedmatype == "All types")
            {
                dataGridView.Rows.Clear();
                foreach (var recipe in recipes)
                {
                    AddRecipesToDataGridView(recipe);
                }
            }
            else //(selectedmatype != null)
            {
                List<Recipe> selectedtype = dataHandler.recipes.Where(recipe => recipe.Type == selectedmatype).ToList();
                dataGridView.Rows.Clear();
                foreach (var recipe in selectedtype)
                {

                    AddRecipesToDataGridView(recipe);
                }
            }
        }


        // �ppna en ny Form n�r man klickar p� en rad f�r att visa detaljerad information. Om du �r inloggad som "Admin" s� kan du �ven redigera receptet
        private void dataGridView_SelectionChanged(object sender, EventArgs e) // Kevin
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0]; // Sista valda raden
                string selectedID = selectedRow.Cells[2].Value.ToString(); // Recept ID
                Recipe selectedRecipe = dataHandler.recipes.FirstOrDefault(recipe => recipe.RecipeID == selectedID); // S�k efter alla recept till du hittar ett med matchande namn

                // Om det finns ett recept i listan som har samma namn som selectedRecipe
                if (selectedRecipe != null)
                {

                    RecipeDetails detailsForm = new RecipeDetails(isAdminSignedIn, selectedRecipe);

                    detailsForm.ShowDialog();

                    Recipe updatedRecipe = detailsForm.AddOrUppdateRecipe;

                    // Om du klickar p� att ta bort receptet
                    if (detailsForm.DeleteRecipe)
                    {
                        // Ta bort receptet fr�n listan
                        dataHandler.RemoveRecipe(selectedRecipe);

                        // Ta bort receptet fr�n dataGridView
                        int rowIndex = selectedRow.Index;
                        dataGridView.Rows.RemoveAt(rowIndex);
                    }

                    // Om du klickar p� att uppdatera receptet och du har gjort �ndringar
                    else if (updatedRecipe.Title != selectedRecipe.Title || updatedRecipe.Description != selectedRecipe.Description || updatedRecipe.Type != selectedRecipe.Type || updatedRecipe.PiImage != selectedRecipe.PiImage)
                    {
                        // Ta bort gamla receptet fr�n listan
                        dataHandler.RemoveRecipe(selectedRecipe);

                        // L�gger till uppdaterade receptet i listan
                        dataHandler.AddRecipe(updatedRecipe);

                        // Uppdaterar dataGridView
                        dataGridView.Rows.Clear();             
                        LoadRecipesIntoDataGridView();
                    }
                }
            }
        }
    }
}