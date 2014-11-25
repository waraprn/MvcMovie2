using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie2.Models
{
    public class Movie
    {
            public int ID { get; set; }
            [StringLength(60, MinimumLength = 3)]
            public string Title { get; set; }
            [Display(Name = "Arrival Date")]
            public DateTime ReleaseDate { get; set; }
            public string Genre { get; set; }
            public decimal Price { get; set; }
            public string Rating { get; set; }
        }

        public class MovieDBContext : DbContext
        {
            public DbSet<Movie> Movies { get; set; }
        }
    }