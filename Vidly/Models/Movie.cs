using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        //properties for representing states
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Release Date")]
        [Required(ErrorMessage = "Please enter a release date.")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Number In Stock")]
        [Required(ErrorMessage = "Please enter a number.")]
        [Range(1,20)]
        public byte NumberInStock { get; set; }
    }
    // /movies/random
}