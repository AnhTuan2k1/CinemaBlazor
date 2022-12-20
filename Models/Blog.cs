using System;
using System.Collections.Generic;

namespace CinemaBlazor.Models
{
    public partial class Blog
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Content1 { get; set; }
        public string? Content2 { get; set; }
        public string? Content3 { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageUrl1 { get; set; }
        public string? ImageUrl2 { get; set; }
        public string? ImageUrl3 { get; set; }
    }
}
