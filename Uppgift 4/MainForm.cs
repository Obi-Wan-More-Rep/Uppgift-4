using System.Diagnostics;
using System.Drawing.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Uppgift_4
{
    public partial class MainForm : Form
    {
        public List<Recipe> recipes { get; set; } = new List<Recipe>();
        public List<Admin> admins { get; set; } = new List<Admin>();
        private const string AdminFilePath = @"admins.txt";
        private const string RecipeFilePath = @"recipes.txt";
        private bool isAdminSignedIn { get; set; } = true; // skapa en Login form, Kamal


        public MainForm()
        {
            InitializeComponent();
            //LoadAdmin();
            LoadRecipes();
        }
        // L�gga till recept i recipe listan och i DataGridView
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

                        if (!comboBox1.Items.Contains(parts[1]))
                            comboBox1.Items.Add(parts[1]);
                    }
                    else
                    {
                        if (recipes.Count > 0)
                        {
                            // Om receptet forts�tter p� n�sta rad
                            // Kolla om recipes listan �r tom f�rst s� att exception inte h�nder
                            int rowIndex = recipes.Count - 1;
                            recipes[rowIndex].Description += line;
                        }
                    }
                }

            }
        }

        // L�gga till admins i admins listan
        private void LoadAdmin()
        {

        }

        // Nollst�lla DataGridView
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

        // L�gg till ett nytt recept
        private void buttonAdd_Click(object sender, EventArgs e) // Vanessa & Cornelia
        {
            RecipeDetails details = new RecipeDetails(isAdminSignedIn);
            details.ShowDialog();

            if (details.AddRecipe)
            {
                Recipe newRecipe = details.UppdatedRecipe;
                //om man skrivit n�got p� det nya receptet kommer den skapa ett nytt recept
                if (newRecipe != null)
                {
                    recipes.Add(newRecipe);
                    dataGridView.Rows.Add(newRecipe.Title); //sparar endast titeln till datagriden
                    UpdateTextFile(); //L�gger nya receptet till textfilen
                }
            }
        }

        private void buttonSignIn_Click(object sender, EventArgs e) // Kamal
        {

        }

        private void buttonSignOut_Click(object sender, EventArgs e) // Kamal
        {

        }

        // Ta bort markerad recipe
        private void buttonDelete_Click(object sender, EventArgs e) // Simon
        {
            // Ta bort receptet fr�n listan
        }



        // �ppna en ny Form n�r man klickar p� en rad f�r att visa detaljerad information. Om du �r inloggad som "Admin" s� kan du �ven redigera receptet
        private void dataGridView1_SelectionChanged(object sender, EventArgs e) // Kevin & Najah
        {

        }

        // Logga in som Admin
        private void SignInButton_Click(object sender, EventArgs e) // Kamal
        {

        }

        // Logga ut
        private void signOutButton_Click(object sender, EventArgs e) // Kamal
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e) // Najah
        {
            string searchText = textBoxSearch.Text.ToLower(); // vara inte k�nslig om  stora boksatver

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

    }
}