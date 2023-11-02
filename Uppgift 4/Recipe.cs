using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_4
{
    public class Recipe
    {
        public string Title { get; set; } 
        public string Type { get; set; }
        public string PiImage { get; set; }
        // La till RecipeID om någon undrar. Om någon vill lägga till ett recept med samma titel som ett redan existerande recept så kan det bli problem om man senare vill ta bort en av recepten.
        // Eftersom då kommer alla recept med samma namn att tas bort
        public string RecipeID { get; set; } 
        public string Description { get; set; }

        public Recipe()
        {
            Title = string.Empty;
            PiImage = string.Empty;
            Type = string.Empty;
            RecipeID = string.Empty;
            Description = string.Empty;
        }
    }
}
