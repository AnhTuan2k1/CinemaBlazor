using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;
using CinemaBlazor.Models;

namespace CinemaBlazor.ViewModels
{
    public class ShowTimeViewModel
    {

        [Display(Name = "ShowTime start time")]
        [Required(ErrorMessage = "Start time is required")]
        public DateTime StartTime { get; set; }

        [Display(Name = "Select a Movie")]
        [Required(ErrorMessage = "Movie is required")]
        public int FilmId { get; set; }

        [Display(Name = "Select a ProjectionRoom")]
        [Required(ErrorMessage = "ProjectionRoom is required")]
        public int ProjectionRoomId { get; set; }


        public virtual Movie Film { get; set; } = null!;
        public virtual ProjectionRoom ProjectionRoom { get; set; } = null!;
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
