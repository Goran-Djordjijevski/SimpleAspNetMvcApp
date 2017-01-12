using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SimpleAspNetMvcApp.Models
{
    public class Movie
    {
        public Movie()
        {

        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the title of the movie.")]
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Enter the genre of the movie.")]
        [RegularExpression((@"^[A-Z]+[a-zA-Z''-'\s]*$"))]
        [StringLength(20)]
        public string Genre { get; set; }

        [Required(ErrorMessage = "Please enter the movie rating.")]
        [StringLength(10)]
        public double Rating { get; set; }
    }
}