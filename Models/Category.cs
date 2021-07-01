using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CET322Final.Models
{
    public class Category
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public virtual List<Recipe> Recipes { get; set; }
    }
}
