using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CinemaBlazor.Shared.Models
{
    public partial class CinemaDBContext : DbContext
    {
        public CinemaDBContext()
        {
        }

        public CinemaDBContext(DbContextOptions<CinemaDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Actor> Actors { get; set; } = null!;
        public virtual DbSet<Blog> Blogs { get; set; } = null!;
        public virtual DbSet<Cinema> Cinemas { get; set; } = null!;
        public virtual DbSet<Comment> Comments { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Director> Directors { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Film> Films { get; set; } = null!;
        public virtual DbSet<FilmActor> FilmActors { get; set; } = null!;
        public virtual DbSet<FilmDirector> FilmDirectors { get; set; } = null!;
        public virtual DbSet<FilmGenre> FilmGenres { get; set; } = null!;
        public virtual DbSet<Invoice> Invoices { get; set; } = null!;
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; } = null!;
        public virtual DbSet<LikeActor> LikeActors { get; set; } = null!;
        public virtual DbSet<LikeDirector> LikeDirectors { get; set; } = null!;
        public virtual DbSet<ProjectionRoom> ProjectionRooms { get; set; } = null!;
        public virtual DbSet<Promotion> Promotions { get; set; } = null!;
        public virtual DbSet<Rate> Rates { get; set; } = null!;
        public virtual DbSet<ShowTime> ShowTimes { get; set; } = null!;
        public virtual DbSet<Ticket> Tickets { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local);Database=CinemaDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .HasColumnName("type");

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<Actor>(entity =>
            {
                entity.ToTable("Actor");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AvatarUrl).HasMaxLength(500);

                entity.Property(e => e.Bio).HasMaxLength(4000);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.Name).HasMaxLength(60);

                entity.Property(e => e.Nationality).HasMaxLength(70);
            });

            modelBuilder.Entity<Blog>(entity =>
            {
                entity.ToTable("Blog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Content1).HasMaxLength(4000);

                entity.Property(e => e.Content2).HasMaxLength(4000);

                entity.Property(e => e.Content3).HasMaxLength(4000);

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.ImageUrl).HasMaxLength(500);

                entity.Property(e => e.ImageUrl1).HasMaxLength(500);

                entity.Property(e => e.ImageUrl2).HasMaxLength(500);

                entity.Property(e => e.ImageUrl3).HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(60);
            });

            modelBuilder.Entity<Cinema>(entity =>
            {
                entity.ToTable("Cinema");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImageUrl).HasMaxLength(500);

                entity.Property(e => e.ImageUrl2).HasMaxLength(500);

                entity.Property(e => e.Location).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(60);
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("Comment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Content).HasMaxLength(4000);

                entity.Property(e => e.FilmId).HasColumnName("FilmID");

                entity.HasOne(d => d.CustomerNavigation)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.Customer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Comment__Custome__5070F446");

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.FilmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Comment__FilmID__4F7CD00D");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AvatarUrl).HasMaxLength(500);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(70);

                entity.Property(e => e.Name).HasMaxLength(60);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Customer__Accoun__29572725");
            });

            modelBuilder.Entity<Director>(entity =>
            {
                entity.ToTable("Director");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AvatarUrl).HasMaxLength(500);

                entity.Property(e => e.Bio).HasMaxLength(4000);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.Name).HasMaxLength(60);

                entity.Property(e => e.Nationality).HasMaxLength(70);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AvatarUrl).HasMaxLength(500);

                entity.Property(e => e.Birthday).HasColumnType("smalldatetime");

                entity.Property(e => e.Email).HasMaxLength(70);

                entity.Property(e => e.Name).HasMaxLength(60);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Employee__Accoun__267ABA7A");
            });

            modelBuilder.Entity<Film>(entity =>
            {
                entity.ToTable("Film");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cast).HasMaxLength(200);

                entity.Property(e => e.Content)
                    .HasMaxLength(4000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Directior).HasMaxLength(50);

                entity.Property(e => e.FilmGenreId).HasColumnName("FilmGenreID");

                entity.Property(e => e.ImageUrl).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nation).HasMaxLength(500);

                entity.Property(e => e.OpenningDay).HasColumnType("smalldatetime");

                entity.Property(e => e.TrailerUrl).HasMaxLength(500);

                entity.HasOne(d => d.FilmGenre)
                    .WithMany(p => p.Films)
                    .HasForeignKey(d => d.FilmGenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Film__FilmGenreI__398D8EEE");
            });

            modelBuilder.Entity<FilmActor>(entity =>
            {
                entity.ToTable("FilmActor");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FilmId).HasColumnName("FilmID");

                entity.HasOne(d => d.ActorNavigation)
                    .WithMany(p => p.FilmActors)
                    .HasForeignKey(d => d.Actor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FilmActor__Actor__412EB0B6");

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.FilmActors)
                    .HasForeignKey(d => d.FilmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FilmActor__FilmI__403A8C7D");
            });

            modelBuilder.Entity<FilmDirector>(entity =>
            {
                entity.ToTable("FilmDirector");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DirectorId).HasColumnName("DirectorID");

                entity.Property(e => e.FilmId).HasColumnName("FilmID");

                entity.HasOne(d => d.Director)
                    .WithMany(p => p.FilmDirectors)
                    .HasForeignKey(d => d.DirectorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FilmDirec__Direc__3D5E1FD2");

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.FilmDirectors)
                    .HasForeignKey(d => d.FilmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FilmDirec__FilmI__3C69FB99");
            });

            modelBuilder.Entity<FilmGenre>(entity =>
            {
                entity.ToTable("FilmGenre");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("Invoice");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateCreate).HasColumnType("smalldatetime");

                entity.Property(e => e.TotalPrice).HasColumnType("money");

                entity.HasOne(d => d.CustomerNavigation)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.Customer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Invoice__Custome__619B8048");

                entity.HasOne(d => d.EmployeeNavigation)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.Employee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Invoice__Employe__628FA481");
            });

            modelBuilder.Entity<InvoiceDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("InvoiceDetail");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.TicketId).HasColumnName("TicketID");

                entity.HasOne(d => d.Invoice)
                    .WithMany()
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__InvoiceDe__Invoi__6477ECF3");

                entity.HasOne(d => d.Ticket)
                    .WithMany()
                    .HasForeignKey(d => d.TicketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__InvoiceDe__Ticke__656C112C");
            });

            modelBuilder.Entity<LikeActor>(entity =>
            {
                entity.ToTable("LikeActor");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActorId).HasColumnName("ActorID");

                entity.HasOne(d => d.Actor)
                    .WithMany(p => p.LikeActors)
                    .HasForeignKey(d => d.ActorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LikeActor__Actor__534D60F1");

                entity.HasOne(d => d.CustomerNavigation)
                    .WithMany(p => p.LikeActors)
                    .HasForeignKey(d => d.Customer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LikeActor__Custo__5441852A");
            });

            modelBuilder.Entity<LikeDirector>(entity =>
            {
                entity.ToTable("LikeDirector");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DirectorId).HasColumnName("DirectorID");

                entity.HasOne(d => d.CustomerNavigation)
                    .WithMany(p => p.LikeDirectors)
                    .HasForeignKey(d => d.Customer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LikeDirec__Custo__5812160E");

                entity.HasOne(d => d.Director)
                    .WithMany(p => p.LikeDirectors)
                    .HasForeignKey(d => d.DirectorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LikeDirec__Direc__571DF1D5");
            });

            modelBuilder.Entity<ProjectionRoom>(entity =>
            {
                entity.ToTable("ProjectionRoom");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CinemaId).HasColumnName("CinemaID");

                entity.Property(e => e.Name).HasMaxLength(60);

                entity.Property(e => e.ScreenType).HasMaxLength(20);

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.ProjectionRooms)
                    .HasForeignKey(d => d.CinemaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Projectio__Cinem__440B1D61");
            });

            modelBuilder.Entity<Promotion>(entity =>
            {
                entity.ToTable("Promotion");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Content).HasMaxLength(4000);

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.ImageUrl).HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(60);

                entity.Property(e => e.OtherImage).HasMaxLength(500);
            });

            modelBuilder.Entity<Rate>(entity =>
            {
                entity.ToTable("Rate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FilmId).HasColumnName("FilmID");

                entity.HasOne(d => d.CustomerNavigation)
                    .WithMany(p => p.Rates)
                    .HasForeignKey(d => d.Customer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Rate__Customer__4CA06362");

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.Rates)
                    .HasForeignKey(d => d.FilmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Rate__FilmID__4BAC3F29");
            });

            modelBuilder.Entity<ShowTime>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CinemaId).HasColumnName("CinemaID");

                entity.Property(e => e.FilmId).HasColumnName("FilmID");

                entity.Property(e => e.ProjectionRoomId).HasColumnName("ProjectionRoomID");

                entity.Property(e => e.StartTime).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.ShowTimes)
                    .HasForeignKey(d => d.CinemaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ShowTimes__Cinem__48CFD27E");

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.ShowTimes)
                    .HasForeignKey(d => d.FilmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ShowTimes__FilmI__46E78A0C");

                entity.HasOne(d => d.ProjectionRoom)
                    .WithMany(p => p.ShowTimes)
                    .HasForeignKey(d => d.ProjectionRoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ShowTimes__Proje__47DBAE45");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.ToTable("Ticket");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateSale).HasColumnType("smalldatetime");

                entity.Property(e => e.Money).HasDefaultValueSql("((100000))");

                entity.Property(e => e.Seat).HasMaxLength(50);

                entity.Property(e => e.TicketType)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Người Lớn')");

                entity.HasOne(d => d.CustomerNavigation)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.Customer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ticket__Customer__5DCAEF64");

                entity.HasOne(d => d.EmployeeNavigation)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.Employee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ticket__Employee__5EBF139D");

                entity.HasOne(d => d.ShowTimesNavigation)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.ShowTimes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ticket__ShowTime__5CD6CB2B");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
