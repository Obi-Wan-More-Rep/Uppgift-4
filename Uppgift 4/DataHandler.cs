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
            LoadRecipes();
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
                    string[] parts = line.Split('#');
                    if (parts.Length == 5)
                    {
                        recipes.Add(new Recipe { Title = parts[0], Type = parts[1], PiImage = parts[2], RecipeID = parts[3], Description = parts[4] });
                    }
                    else //Kevin
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
                // Skapa en ny tom ".txt" fil om det inte redan existerar någon
                File.Create(AdminFilePath).Close();
            }

            using (StreamReader reader = new StreamReader(AdminFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('#');
                    if (parts.Length == 2)
                    {
                        admins.Add(new Admin { Username = parts[0], Password = parts[1] });
                    }
                }
            }
        }

        // Uppdatera textfilen med recipes listan
        public void UpdateTextFile() // både Simon och Kevin skrev samma sak så det räcker att kalla på metoden på samma ställe (härifrån)
        {
            Debug.WriteLine("Updating text file...");
            using (StreamWriter writer = new StreamWriter(RecipeFilePath, false))
            {
                foreach (Recipe recipe in recipes)
                {
                    writer.WriteLine($"{recipe.Title}#{recipe.Type}#{recipe.PiImage}#{recipe.RecipeID}#{recipe.Description}"); // Vanessa eller Najah ändrade split tecknet från ',' till '#'
                }
            }
            Debug.WriteLine("Text file updated.");
        }

        //// Läs textfilen och spara dem i en lista.        Denna metod är vad som skapade duplicerings problemet. För att undvika duplicera recept så får man enbart köra "LoadRecipes()" bara en gång (när man startar programmet) Kevin
        /// Jag misstänker att man behöver en "using()" eller ".Close()" på loadRecipes eller något liknande om man vill köra "LoadRecipes()" metoden flera gånger i programmet.
        //public List<Recipe> GetRecipes()
        //{
        //    LoadRecipes();
        //    return recipes;
        //}

        // Lägg till recept i listan och uppdatera textfilen
        public void AddRecipe(Recipe recipe) // Kevin
        {
            recipes.Add(recipe);
            UpdateTextFile();
        }

        // Ta bort recept i listan och uppdatera textfilen
        public void RemoveRecipe(Recipe selectedRecipe) // Kevin
        {
            recipes.RemoveAll(recipe => recipe.RecipeID == selectedRecipe.RecipeID); // recipes .Remove() fungerar inte eftersom av någon anledning så ändras "HashCode" för selectedRecipe objektet när den tas emot i denna metod. Man kan se det med hjälp av en "Debug.WriteLine()" "Debug.WriteLine($"Recipe in List HashCode: {recipe.GetHashCode()}");"
            UpdateTextFile();
        }
    }
}
