using System;
using System.Collections.Generic;

namespace CinemaBlazor.Models
{
    public partial class Director
    {
        public Director()
        {
            FilmDirectors = new HashSet<FilmDirector>();
            LikeDirectors = new HashSet<LikeDirector>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? Birthday { get; set; }
        public double? Height { get; set; }
        public string? Nationality { get; set; }
        public string? Bio { get; set; }
        public string? AvatarUrl { get; set; }

        public virtual ICollection<FilmDirector> FilmDirectors { get; set; }
        public virtual ICollection<LikeDirector> LikeDirectors { get; set; }
    }
}
