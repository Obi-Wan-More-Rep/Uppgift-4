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
        private void LoadRecipes()
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
                        recipes.Add(new Recipe { Title = parts[0], Description = parts[1], Type = parts[2] });
                        dataGridView.Rows.Add(parts[0]);
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
                    writer.WriteLine($"{recipe.Title},{recipe.Description},{recipe.Type}");
                }

            }
        }

        // L�gg till ett nytt recept
        private void buttonAdd_Click(object sender, EventArgs e) // Vanessa & Cornelia
        {

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


        // s�ka p� recept fr�n recipes listan och visa i DataGridView
        private void buttonSearch_Click(object sender, EventArgs e) // Najah
        {

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
                    recipe.Type.ToLower().Contains(searchText) )
                  
                {
                    dataGridView.Rows.Add(recipe.Title, recipe.Description, recipe.Type);
                }
            }
        }
    }
}