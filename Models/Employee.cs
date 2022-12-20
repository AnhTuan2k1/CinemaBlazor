using System;
using System.Collections.Generic;

namespace CinemaBlazor.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Invoices = new HashSet<MovieOrder>();
            Tickets = new HashSet<Ticket>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public DateTime? Birthday { get; set; }
        public string? AvatarUrl { get; set; }
        public int AccountId { get; set; }

        public virtual ICollection<MovieOrder> Invoices { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
