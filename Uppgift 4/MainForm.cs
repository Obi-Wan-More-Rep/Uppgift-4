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
            List<Recipe> recipes = dataHandler.GetRecipes(); // få en lista av recepten från DataHandler klassen
            foreach (Recipe recipe in recipes)
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

        //stängde tillfälligt av ta bort metoden. "recipe" listan är under DataHandler metoden så du behöver inte göra många ändringar i denna metod. Exempelvis kan du skriva "dataHandler.recipes" eller "dataHandler.GetRecipes"

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



        // söka på recept från recipes listan och visa i DataGridView
        private void textBoxSearch_TextChanged(object sender, EventArgs e) // Najah
        {
            string searchText = textBoxSearch.Text.ToLower(); // vara inte känslig om  stora boksatver
            dataGridView.Rows.Clear();

            List<Recipe> recipes = dataHandler.recipes;  // Av någon anledning så dupliceras recept i dataGridView om man skriver "dataHandler.GetRecipes()" så jag löste det genom att skriva istället "dataHandler.recipes" (kevin)
            foreach (var recipe in recipes)
            {
                if (recipe.Title.ToLower().Contains(searchText) ||
                    recipe.Type.ToLower().Contains(searchText))

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

        // Lägg till ett nytt recept
        private void buttonAdd_Click(object sender, EventArgs e) // Vanessa & Cornelia
        {
            RecipeDetails details = new RecipeDetails(isAdminSignedIn);
            details.ShowDialog();

            if (details.AddRecipe)
            {
                Recipe newRecipe = details.UppdatedRecipe;
                // om man skrivit något på det nya receptet kommer den skapa ett nytt recept
                if (newRecipe != null)
                {
                    // Lägg till ett nytt recept i listan och textfilen
                    dataHandler.AddRecipe(newRecipe); 

                    // Lägg till receptet i dataGridView
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
            // Ta bort receptet från listan
            //TaBort();
        }


        // Stängde tillfälligt av comboBox. "recipe" listan är under DataHandler metoden så du behöver inte göra många ändringar i denna metod. Exempelvis kan du skriva "dataHandler.recipes" eller "dataHandler.GetRecipes"
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // Najah
        {
            //string selectedmatype = comboBox1.SelectedItem.ToString();
            //if (selectedmatype != null)
            //{
            //    List<Recipe> selectedtype = recipes.Where(recipe => recipe.Type == selectedmatype).ToList();
            //    dataGridView.Rows.Clear();
            //    foreach (var recipe in selectedtype)
            //    {
            //        dataGridView.Rows.Add(recipe.Title);
            //    }
            //}
        }



        // Öppna en ny Form när man klickar på en rad för att visa detaljerad information. Om du är inloggad som "Admin" så kan du även redigera receptet
        private void dataGridView_SelectionChanged(object sender, EventArgs e) // Kevin
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0]; // Sista valda raden
                string selectedTitle = selectedRow.Cells[0].Value.ToString(); // namnet på receptet
                Recipe selectedRecipe = dataHandler.GetRecipes().FirstOrDefault(recipe => recipe.Title == selectedTitle); // Sök efter alla recept till du hittar ett med matchande namn

                // Om det finns ett recept i listan som har samma namn som selectedRecipe
                if (selectedRecipe != null)
                {
                    // Öppna en instans av Formen detailsForm
                    RecipeDetails detailsForm = new RecipeDetails(isAdminSignedIn, selectedRecipe);
                    detailsForm.ShowDialog();

                    Recipe updatedRecipe = detailsForm.UppdatedRecipe;

                    // Om du klickar på att ta bort receptet
                    if (detailsForm.DeleteRecipe)
                    {
                        // Ta bort receptet från listan
                        dataHandler.RemoveRecipe(selectedRecipe);

                        // Ta bort receptet från dataGridView
                        int rowIndex = selectedRow.Index;
                        dataGridView.Rows.RemoveAt(rowIndex);
                    }

                    // Om du klickar på att uppdatera receptet och du har gjort ändringar
                    else if (updatedRecipe.Title != selectedRecipe.Title || updatedRecipe.Description != selectedRecipe.Description || updatedRecipe.Type != selectedRecipe.Type)
                    {
                        // Ta bort gamla receptet från listan
                        dataHandler.RemoveRecipe(selectedRecipe);

                        // Lägger till uppdaterade receptet i listan
                        dataHandler.AddRecipe(updatedRecipe);

                        // Uppdaterar dataGridView utan att rensa hela den och läsa om den. Detta fixar buggen med att recept duppliceras
                        int rowIndex = selectedRow.Index;
                        dataGridView.Rows[rowIndex].Cells[0].Value = updatedRecipe.Title;
                    }
                }
            }
        }


    }
}