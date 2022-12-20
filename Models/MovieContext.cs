using CinemaBlazor.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CinemaBlazor.Models
{
    public class MovieContext:IdentityDbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Cinema> Cinemas { get; set; }
        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Producer> Producers { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<MovieActor> MovieActors { get; set; }
        public virtual DbSet<MovieInCinema> MovieInCinemas { get; set; }
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<MovieOrder> MovieOrders { get; set; }

        public virtual DbSet<Blog> Blogs { get; set; } = null!;
        public virtual DbSet<Comment> Comments { get; set; } = null!;
        //public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Director> Directors { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<FilmActor> FilmActors { get; set; } = null!;
        public virtual DbSet<FilmDirector> FilmDirectors { get; set; } = null!;
        //public virtual DbSet<FilmGenre> FilmGenres { get; set; } = null!;
        public virtual DbSet<LikeActor> LikeActors { get; set; } = null!;
        public virtual DbSet<LikeDirector> LikeDirectors { get; set; } = null!;
        public virtual DbSet<ProjectionRoom> ProjectionRooms { get; set; } = null!;
        public virtual DbSet<Promotion> Promotions { get; set; } = null!;
        public virtual DbSet<Rate> Rates { get; set; } = null!;
        public virtual DbSet<ShowTime> ShowTimes { get; set; } = null!;
        public virtual DbSet<Ticket> Tickets { get; set; } = null!;

        public MovieContext() { }
        public MovieContext(DbContextOptions options) : base(options)
        { 
        
        
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

    }
}
