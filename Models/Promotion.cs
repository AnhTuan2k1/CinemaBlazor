using System;
using System.Collections.Generic;

namespace CinemaBlazor.Models
{
    public partial class Promotion
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Content { get; set; }
        public string? ImageUrl { get; set; }
        public string? OtherImage { get; set; }
    }
}
