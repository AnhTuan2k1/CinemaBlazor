//using System;
//using System.Collections.Generic;

//namespace CinemaBlazor.Models
//{
//    public partial class Customer
//    {
//        public Customer()
//        {
//            Comments = new HashSet<Comment>();
//            Invoices = new HashSet<MovieOrder>();
//            LikeActors = new HashSet<LikeActor>();
//            LikeDirectors = new HashSet<LikeDirector>();
//            Rates = new HashSet<Rate>();
//            Tickets = new HashSet<Ticket>();
//        }

//        public int Id { get; set; }
//        public string? Name { get; set; }
//        public string? Email { get; set; }
//        public string? Phone { get; set; }
//        public DateTime? Birthday { get; set; }
//        public string? AvatarUrl { get; set; }
//        public int AccountId { get; set; }

//        public virtual ICollection<Comment> Comments { get; set; }
//        public virtual ICollection<MovieOrder> Invoices { get; set; }
//        public virtual ICollection<LikeActor> LikeActors { get; set; }
//        public virtual ICollection<LikeDirector> LikeDirectors { get; set; }
//        public virtual ICollection<Rate> Rates { get; set; }
//        public virtual ICollection<Ticket> Tickets { get; set; }
//    }
//}
