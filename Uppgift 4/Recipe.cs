﻿using System;
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
        public string Description { get; set; }
        //public int RecipeId { get; set; }

        public Recipe()
        {
            Title = string.Empty;
            PiImage = string.Empty;
            Type = string.Empty;
            Description = string.Empty;
        }
    }
}
