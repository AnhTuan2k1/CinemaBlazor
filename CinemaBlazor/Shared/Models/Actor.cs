using System;
using System.Collections.Generic;

namespace CinemaBlazor.Shared.Models
{
    public partial class Actor
    {
        public Actor()
        {
            FilmActors = new HashSet<FilmActor>();
            LikeActors = new HashSet<LikeActor>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? Birthday { get; set; }
        public double? Height { get; set; }
        public string? Nationality { get; set; }
        public string? Bio { get; set; }
        public string? AvatarUrl { get; set; }

        public virtual ICollection<FilmActor> FilmActors { get; set; }
        public virtual ICollection<LikeActor> LikeActors { get; set; }
    }
}
