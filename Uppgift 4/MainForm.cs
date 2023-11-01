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
            List<Recipe> recipes = dataHandler.GetRecipes(); // f� en lista av recepten fr�n DataHandler klassen
            foreach (Recipe recipe in recipes)
            {
                if (File.Exists(recipe.PiImage))
                {
                    Image image = Image.FromFile(recipe.PiImage);
                    dataGridView.Rows.Add(recipe.Title, image);
                    if (!comboBox1.Items.Contains(recipe.Type))
                    {
                        comboBox1.Items.Add(recipe.Type);

                    }
                }
                else
                {
                    dataGridView.Rows.Add(recipe.Title);
                    if (!comboBox1.Items.Contains(recipe.Type))
                    {
                        comboBox1.Items.Add(recipe.Type);

                    }
                }
            }
        }

        //st�ngde tillf�lligt av ta bort metoden. "recipe" listan �r under DataHandler metoden s� du beh�ver inte g�ra m�nga �ndringar i denna metod. Exempelvis kan du skriva "dataHandler.recipes" eller "dataHandler.GetRecipes"

        //public void TaBort()
        //{
        //    var index = dataGridView.SelectedCells[0];
        //    if (index != null)
        //        recipes.RemoveAt(index.RowIndex);
        //    dataGridView.Rows.RemoveAt(index.RowIndex);
        //    StreamWriter sw = new StreamWriter(RecipeFilePath);
        //    foreach (var s in recipes)
        //    {
        //        sw.WriteLine(s.Title + "," + s.Description + "," + s.Type);

        //    }
        //    sw.Close();
        //}


        // L�gg till ett nytt recept
        private void buttonAdd_Click(object sender, EventArgs e) // Vanessa & Cornelia
        {
            RecipeDetails details = new RecipeDetails(isAdminSignedIn);
            details.ShowDialog();

            if (details.AddRecipe)
            {
                Recipe newRecipe = details.UppdatedRecipe;
                // om man skrivit n�got p� det nya receptet kommer den skapa ett nytt recept
                if (newRecipe != null)
                {
                    // L�gg till ett nytt recept i listan och textfilen
                    dataHandler.AddRecipe(newRecipe);

                    // L�gg till receptet i dataGridView
                    if (File.Exists(newRecipe.PiImage)) //Kevin, La till if statements
                    {
                        Image image = Image.FromFile(newRecipe.PiImage);
                        dataGridView.Rows.Add(newRecipe.Title, image);
                    }
                    else
                    {
                        dataGridView.Rows.Add(newRecipe.Title);
                    }
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
            //test
            // Ta bort receptet fr�n listan
            //TaBort();
        }

        // �ppna en ny Form n�r man klickar p� en rad f�r att visa detaljerad information. Om du �r inloggad som "Admin" s� kan du �ven redigera receptet
        private void dataGridView_SelectionChanged(object sender, EventArgs e) // Kevin
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0]; // Sista valda raden
                string selectedTitle = selectedRow.Cells[0].Value.ToString(); // namnet p� receptet
                Recipe selectedRecipe = dataHandler.GetRecipes().FirstOrDefault(recipe => recipe.Title == selectedTitle); // S�k efter alla recept till du hittar ett med matchande namn

                // Om det finns ett recept i listan som har samma namn som selectedRecipe
                if (selectedRecipe != null)
                {

                    RecipeDetails detailsForm = new RecipeDetails(isAdminSignedIn, selectedRecipe);

                    detailsForm.ShowDialog();

                    Recipe updatedRecipe = detailsForm.UppdatedRecipe;

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
                    else if (updatedRecipe.Title != selectedRecipe.Title || updatedRecipe.Description != selectedRecipe.Description || updatedRecipe.Type != selectedRecipe.Type)
                    {
                        // Ta bort gamla receptet fr�n listan
                        dataHandler.RemoveRecipe(selectedRecipe);

                        // L�gger till uppdaterade receptet i listan
                        dataHandler.AddRecipe(updatedRecipe);

                        // Uppdaterar dataGridView utan att rensa hela den och l�sa om den. Detta fixar buggen med att recept duppliceras
                        int rowIndex = selectedRow.Index;
                        dataGridView.Rows[rowIndex].Cells[0].Value = updatedRecipe.Title;
                    }

                }
            }



        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.ToLower(); // Text to search for (convert to lowercase for case-insensitive search)

            List<Recipe> recipes = dataHandler.GetRecipes();

            dataGridView.Rows.Clear(); // Clear the existing rows in the DataGridView

            foreach (Recipe recipe in recipes)
            {
                if (recipe.Title.ToLower().Contains(searchText))
                {
                    bool alreadyExists = false;

                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (row.Cells.Count > 0 && row.Cells[0].Value != null && row.Cells[0].Value.ToString() == recipe.Title)
                        {
                            alreadyExists = true;
                            break;
                        }
                    }

                    if (!alreadyExists)
                    {
                        if (File.Exists(recipe.PiImage))
                        {
                            Image image = Image.FromFile(recipe.PiImage);
                            dataGridView.Rows.Add(recipe.Title, image);
                        }
                        else
                        {
                            dataGridView.Rows.Add(recipe.Title);
                        }
                    }
                }
            }
        }
    }
}