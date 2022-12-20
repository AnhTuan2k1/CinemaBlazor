using System;
using System.Collections.Generic;

namespace CinemaBlazor.Models
{
    public partial class FilmActor
    {
        public int Id { get; set; }
        public int FilmId { get; set; }
        public int Actor { get; set; }

        public virtual Actor ActorNavigation { get; set; } = null!;
        public virtual Movie Film { get; set; } = null!;
    }
}
