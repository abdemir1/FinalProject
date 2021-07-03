using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CET322Final.Models
{
    public class Recipe
    {
        public Recipe()
        {
            CreatedDate = DateTime.Now;
        }

        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string ImageURL { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreatedDate { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public string MyUserId { get; set; }
        public virtual MyUser MyUser { get; set; }

    }
}
