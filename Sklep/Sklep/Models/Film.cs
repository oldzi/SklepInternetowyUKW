﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sklep.Models
{
    public class Film
    {
        
        public int FilmId { get; set; }
        [Required(ErrorMessage = "Wpisz tytuł")]
        [StringLength(50)]
        public string Title { get; set; }
        public string Director { get; set; }
        public string Desc { get; set; }
        [Required(ErrorMessage = "Podaj cenę")]
        public decimal Price { get; set; }
        public DateTime AddDate { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

    }
}