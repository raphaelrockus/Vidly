using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte? GenreId { get; set; }

        [Display(Name = "Release Date")]
        [Required(ErrorMessage = "Please enter a release date.")]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Number In Stock")]
        [Required(ErrorMessage = "Please enter a number.")]
        [Range(1, 20)]
        public byte? NumberInStock { get; set; }


        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {

            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }

        public string Title
        {
            get
            {
                return Id != 0 ? "EditMovie" : "New Movie";
            }
        }
    }
}