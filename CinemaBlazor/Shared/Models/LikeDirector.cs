using System;
using System.Collections.Generic;

namespace CinemaBlazor.Shared.Models
{
    public partial class LikeDirector
    {
        public int Id { get; set; }
        public int DirectorId { get; set; }
        public int Customer { get; set; }

        public virtual Customer CustomerNavigation { get; set; } = null!;
        public virtual Director Director { get; set; } = null!;
    }
}
