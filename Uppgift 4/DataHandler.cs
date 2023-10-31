using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_4
{
    public class DataHandler
    {
        public List<Recipe> recipes { get; set; } = new List<Recipe>();
        public List<Admin> admins { get; set; } = new List<Admin>();
        private const string RecipeFilePath = $@"../../../recipe/recipe.txt";
        private const string AdminFilePath = @"../../../Admin/Admins.txt";

        public DataHandler()
        {
            LoadAdmin();
        }

        // Lägga till recept i recipe listan och i DataGridView
        private void LoadRecipes()
        {
            if (!File.Exists(RecipeFilePath))
            {
                // skapa en ny tom ".txt" fil
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

        // Läs textfilen och lägg till alla Admins i listan
        private void LoadAdmin()
        {
            if (!File.Exists(AdminFilePath))
            {
                // Create a new empty ".txt" file
                File.Create(AdminFilePath).Close();
            }

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

        // Uppdatera textfilen med recipes listan
        public void UpdateTextFile()
        {
            Debug.WriteLine("Updating text file...");
            using (StreamWriter writer = new StreamWriter(RecipeFilePath, false))
            {
                foreach (Recipe recipe in recipes)
                {
                    writer.WriteLine($"{recipe.Title},{recipe.Type},{recipe.Description}");
                }
            }
            Debug.WriteLine("Text file updated.");
        }

        // Hämta in alla recept i en variabel
        public List<Recipe> GetRecipes()
        {
            LoadRecipes();
            return recipes;
        }

        // Lägg till till recept i listan och uppdatera textfilen
        public void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
            UpdateTextFile();
        }

        // Ta bort recept i listan och uppdatera textfilen
        public void RemoveRecipe(Recipe selectedRecipe)
        {
            recipes.RemoveAll(recipe => recipe.Title == selectedRecipe.Title);
            UpdateTextFile();
        }
    }
}
