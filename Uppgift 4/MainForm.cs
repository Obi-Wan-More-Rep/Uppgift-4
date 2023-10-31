using System.Diagnostics;
using System.Drawing.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace Uppgift_4
{
    public partial class MainForm : Form
    {
        public List<Recipe> recipes { get; set; } = new List<Recipe>();
        public List<Admin> admins { get; set; } = new List<Admin>();
        private const string AdminFilePath = @"../../../Admin/Admins.txt";
        private const string RecipeFilePath = $@"../../../recipe/recipe.txt";

        private bool isAdminSignedIn { get; set; } // skapa en Login form, Kamal


        public MainForm()
        {
            InitializeComponent();
            LoadAdmin();
            LoadRecipes();

        }
        // Lägga till recept i recipe listan och i DataGridView
        private void LoadRecipes() // Kevin och Najah
        {
            if (!File.Exists(RecipeFilePath))
            {
                // Create a new empty ".txt" file
                File.Create(RecipeFilePath).Close();
            }

            using (StreamReader reader = new StreamReader(RecipeFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        recipes.Add(new Recipe { Title = parts[0], Type = parts[1], Description = parts[2] });
                        dataGridView.Rows.Add(parts[0]);
                        string imagePath = $@"../../../Bilder/{parts[0]}.jpg";

                        if (System.IO.File.Exists(imagePath))
                        {
                            int rowIdx = dataGridView.Rows.Count - 1;
                            Image image = Image.FromFile(imagePath);
                            dataGridView.Rows[rowIdx].Cells[1].Value = image;
                        }

                        if (!comboBox1.Items.Contains(parts[1]))
                            comboBox1.Items.Add(parts[1]);
                    }
                    else
                    {
                        if (recipes.Count > 0)
                        {
                            // Om receptet fortsätter på nästa rad
                            // Kolla om recipes listan är tom först så att exception inte händer
                            int rowIndex = recipes.Count - 1;
                            recipes[rowIndex].Description += line;
                        }
                    }
                }

            }
        }

        // Lägga till admins i admins listan
        private void LoadAdmin() // Najah
        {
            using (StreamReader reader = new StreamReader(AdminFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        admins.Add(new Admin { Username = parts[0], Password = parts[1] });
                    }
                }
            }

        }
        public void TaBort()
        {
            var index = dataGridView.SelectedCells[0];
            if (index != null)
                recipes.RemoveAt(index.RowIndex);
            dataGridView.Rows.RemoveAt(index.RowIndex);
            StreamWriter sw = new StreamWriter(RecipeFilePath);
            foreach (var s in recipes)
            {
                sw.WriteLine(s.Title + "," + s.Description + "," + s.Type);

            }
            sw.Close();
        }


        // Nollställa DataGridView
        private void ResetDataGridView()
        {
            dataGridView.Rows.Clear();
        }


        //Uppdatera receptet i textfilen
        private void UpdateTextFile() // Kevin
        {
            using (StreamWriter writer = new StreamWriter(RecipeFilePath, false))
            {
                foreach (Recipe recipe in recipes)
                {
                    writer.WriteLine($"{recipe.Title},{recipe.Type},{recipe.Description}");
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
                //om man skrivit något på det nya receptet kommer den skapa ett nytt recept
                if (newRecipe != null)
                {
                    recipes.Add(newRecipe);
                    dataGridView.Rows.Add(newRecipe.Title); //sparar endast titeln till datagriden
                    UpdateTextFile(); //Lägger nya receptet till textfilen
                }
            }
        }


        private void buttonSignIn_Click(object sender, EventArgs e) // Kamal
        {
            FrmLogin frmLogin = new FrmLogin(admins);
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
            TaBort();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e) // Najah
        {
            string searchText = textBoxSearch.Text.ToLower(); // vara inte känslig om  stora boksatver

            dataGridView.Rows.Clear();

            foreach (var recipe in recipes)
            {
                if (recipe.Title.ToLower().Contains(searchText) ||
                    recipe.Type.ToLower().Contains(searchText))

                {
                    dataGridView.Rows.Add(recipe.Title, recipe.Description, recipe.Type);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // Najah
        {
            string selectedmatype = comboBox1.SelectedItem.ToString();
            if (selectedmatype != null)
            {
                List<Recipe> selectedtype = recipes.Where(recipe => recipe.Type == selectedmatype).ToList();
                dataGridView.Rows.Clear();
                foreach (var recipe in selectedtype)
                {
                    dataGridView.Rows.Add(recipe.Title);
                }
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e) // Kevin
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                string selectedTitle = selectedRow.Cells[0].Value.ToString();
                Recipe selectedRecipe = recipes.FirstOrDefault(recipe => recipe.Title == selectedTitle);

                // Om selectedRecipe inte returnerar null
                if (selectedRecipe != null)
                {
                    RecipeDetails detailsForm = new RecipeDetails(isAdminSignedIn, selectedRecipe);
                    detailsForm.ShowDialog();

                    Recipe updatedRecipe = detailsForm.UppdatedRecipe;

                    if (detailsForm.DeleteRecipe)
                    {
                        recipes.Remove(selectedRecipe);
                        UpdateTextFile();

                        int rowIndex = selectedRow.Index;
                        dataGridView.Rows.RemoveAt(rowIndex);
                    }

                    else if (updatedRecipe.Title != selectedRecipe.Title || updatedRecipe.Description != selectedRecipe.Description || updatedRecipe.Type != selectedRecipe.Type)
                    {
                        recipes.Remove(selectedRecipe);
                        recipes.Add(updatedRecipe);

                        UpdateTextFile();

                        // Uppdaterar DataGridView utan att rensa hela den och läsa om den. Detta fixar buggen med att recept duppliceras
                        int rowIndex = selectedRow.Index;
                        dataGridView.Rows[rowIndex].Cells[0].Value = updatedRecipe.Title;
                    }
                }
            }
        }


    }
}