using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sklep.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Wprowadź nazwę kategorii")]
        public string Name { get; set; }
        public string Desc { get; set; }

        //prop i dwa razy tab
        //for i dwa razy tab

        public ICollection<Film> Films { get; set; }

    }
}