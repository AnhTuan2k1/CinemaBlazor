using System;
using System.Collections.Generic;

namespace CinemaBlazor.Models
{
    public partial class FilmDirector
    {
        public int Id { get; set; }
        public int FilmId { get; set; }
        public int DirectorId { get; set; }

        public virtual Director Director { get; set; } = null!;
        public virtual Movie Film { get; set; } = null!;
    }
}
