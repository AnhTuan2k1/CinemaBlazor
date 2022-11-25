using System;
using System.Collections.Generic;

namespace CinemaBlazor.Shared.Models
{
    public partial class LikeActor
    {
        public int Id { get; set; }
        public int ActorId { get; set; }
        public int Customer { get; set; }

        public virtual Actor Actor { get; set; } = null!;
        public virtual Customer CustomerNavigation { get; set; } = null!;
    }
}
