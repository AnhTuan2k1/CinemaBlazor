﻿using System;
using System.Collections.Generic;

namespace CinemaBlazor.Models
{
    public partial class Rate
    {
        public int Id { get; set; }
        public int Point { get; set; }
        public int FilmId { get; set; }
        public int Customer { get; set; }

       // public virtual Customer CustomerNavigation { get; set; } = null!;
        public virtual Movie movie { get; set; } = null!;
    }
}
