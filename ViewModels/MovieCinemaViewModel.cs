using CinemaBlazor.Models;
using System.Collections.Generic;

namespace CinemaBlazor.ViewModels
{
    public class MovieCinemaViewModel
    {
        public virtual Cinema Cinema { get; set; }
        public virtual List<MovieInCinema> Movies { get; set; }
    }
}
