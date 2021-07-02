using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CET322Final.Models
{
    public class SearchViewModel
    {

        public string SearchText { get; set; }

        //public bool ShowAll { get; set; }

        public List<Recipe> Result { get; set; }


    }
}
