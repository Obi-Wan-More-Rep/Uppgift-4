using System.Diagnostics;
using System.Windows.Forms;

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
        // Lägga till recept i recipe listan och i DataGridView
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

        //Uppdatera receptet i textfilen

        private void UpdateTextFile()
        {
            Debug.WriteLine("Uppdaterar textfilen");
            using (StreamWriter writer = new StreamWriter(RecipeFilePath, false))
            {
                foreach (Recipe recipe in recipes)
                {
                    writer.WriteLine($"{recipe.Title},{recipe.Description},{recipe.Type}");
                }
                Debug.WriteLine("Recept textfilen är uppdaterad.");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {

        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }
    }
}