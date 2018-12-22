using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HotelAdministation.Models
{
    public partial class cinemaContext : DbContext
    {
        public cinemaContext()
        {
        }

        public cinemaContext(DbContextOptions<cinemaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actor> Actor { get; set; }
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<Cinema> Cinema { get; set; }
        public virtual DbSet<CinemaCategory> CinemaCategory { get; set; }
        public virtual DbSet<CinemaStatus> CinemaStatus { get; set; }
        public virtual DbSet<Director> Director { get; set; }
        public virtual DbSet<Film> Film { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Hall> Hall { get; set; }
        public virtual DbSet<HallList> HallList { get; set; }
        public virtual DbSet<ListOfActors> ListOfActors { get; set; }
        public virtual DbSet<ListOfAreas> ListOfAreas { get; set; }
        public virtual DbSet<ListOfCinemaCategories> ListOfCinemaCategories { get; set; }
        public virtual DbSet<ListOfDirectors> ListOfDirectors { get; set; }
        public virtual DbSet<ListOfGenres> ListOfGenres { get; set; }
        public virtual DbSet<ListOfOperators> ListOfOperators { get; set; }
        public virtual DbSet<ListOfPrizes> ListOfPrizes { get; set; }
        public virtual DbSet<ListOfProductions> ListOfProductions { get; set; }
        public virtual DbSet<Operator> Operator { get; set; }
        public virtual DbSet<Prize> Prize { get; set; }
        public virtual DbSet<Production> Production { get; set; }
        public virtual DbSet<Seance> Seance { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=localhost;Database=cinema;Username=cinema;Password=cinema");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>(entity =>
            {
                entity.ToTable("actor");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("firstName")
                    .HasMaxLength(32);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("lastName")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Area>(entity =>
            {
                entity.ToTable("area");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Cinema>(entity =>
            {
                entity.ToTable("cinema");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasColumnName("area")
                    .HasMaxLength(32);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(32);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Cinema)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cinema_fk0");
            });

            modelBuilder.Entity<CinemaCategory>(entity =>
            {
                entity.ToTable("cinemaCategory");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<CinemaStatus>(entity =>
            {
                entity.ToTable("cinemaStatus");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(16);
            });

            modelBuilder.Entity<Director>(entity =>
            {
                entity.ToTable("director");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("firstName")
                    .HasMaxLength(32);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("lastName")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Film>(entity =>
            {
                entity.ToTable("film");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Duration)
                    .HasColumnName("duration")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnName("image");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64);

                entity.Property(e => e.RentalPrice).HasColumnName("rentalPrice");
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.ToTable("genre");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Hall>(entity =>
            {
                entity.ToTable("hall");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Capacity).HasColumnName("capacity");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.TicketsLeft).HasColumnName("ticketsLeft");
            });

            modelBuilder.Entity<HallList>(entity =>
            {
                entity.ToTable("hallList");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cinema).HasColumnName("cinema");

                entity.Property(e => e.Hall).HasColumnName("hall");

                entity.HasOne(d => d.CinemaNavigation)
                    .WithMany(p => p.HallList)
                    .HasForeignKey(d => d.Cinema)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("hallList_fk0");

                entity.HasOne(d => d.HallNavigation)
                    .WithMany(p => p.HallList)
                    .HasForeignKey(d => d.Hall)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("hallList_fk1");
            });

            modelBuilder.Entity<ListOfActors>(entity =>
            {
                entity.ToTable("listOfActors");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Actor).HasColumnName("actor");

                entity.Property(e => e.Film).HasColumnName("film");

                entity.HasOne(d => d.ActorNavigation)
                    .WithMany(p => p.ListOfActors)
                    .HasForeignKey(d => d.Actor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("listOfActors_fk1");

                entity.HasOne(d => d.FilmNavigation)
                    .WithMany(p => p.ListOfActors)
                    .HasForeignKey(d => d.Film)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("listOfActors_fk0");
            });

            modelBuilder.Entity<ListOfAreas>(entity =>
            {
                entity.ToTable("listOfAreas");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.Cinema).HasColumnName("cinema");

                entity.HasOne(d => d.AreaNavigation)
                    .WithMany(p => p.ListOfAreas)
                    .HasForeignKey(d => d.Area)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("listOfAreas_fk1");

                entity.HasOne(d => d.CinemaNavigation)
                    .WithMany(p => p.ListOfAreas)
                    .HasForeignKey(d => d.Cinema)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("listOfAreas_fk0");
            });

            modelBuilder.Entity<ListOfCinemaCategories>(entity =>
            {
                entity.ToTable("listOfCinemaCategories");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cinema).HasColumnName("cinema");

                entity.Property(e => e.CinemaCategory).HasColumnName("cinemaCategory");

                entity.HasOne(d => d.CinemaNavigation)
                    .WithMany(p => p.ListOfCinemaCategories)
                    .HasForeignKey(d => d.Cinema)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("listOfCinemaCategories_fk0");

                entity.HasOne(d => d.CinemaCategoryNavigation)
                    .WithMany(p => p.ListOfCinemaCategories)
                    .HasForeignKey(d => d.CinemaCategory)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("listOfCinemaCategories_fk1");
            });

            modelBuilder.Entity<ListOfDirectors>(entity =>
            {
                entity.ToTable("listOfDirectors");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Director).HasColumnName("director");

                entity.Property(e => e.Film).HasColumnName("film");

                entity.HasOne(d => d.DirectorNavigation)
                    .WithMany(p => p.ListOfDirectors)
                    .HasForeignKey(d => d.Director)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("listOfDirectors_fk1");

                entity.HasOne(d => d.FilmNavigation)
                    .WithMany(p => p.ListOfDirectors)
                    .HasForeignKey(d => d.Film)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("listOfDirectors_fk0");
            });

            modelBuilder.Entity<ListOfGenres>(entity =>
            {
                entity.ToTable("listOfGenres");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Film).HasColumnName("film");

                entity.Property(e => e.Genre).HasColumnName("genre");

                entity.HasOne(d => d.FilmNavigation)
                    .WithMany(p => p.ListOfGenres)
                    .HasForeignKey(d => d.Film)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("listOfGenres_fk0");

                entity.HasOne(d => d.GenreNavigation)
                    .WithMany(p => p.ListOfGenres)
                    .HasForeignKey(d => d.Genre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("listOfGenres_fk1");
            });

            modelBuilder.Entity<ListOfOperators>(entity =>
            {
                entity.ToTable("listOfOperators");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Film).HasColumnName("film");

                entity.Property(e => e.Operator).HasColumnName("operator");

                entity.HasOne(d => d.FilmNavigation)
                    .WithMany(p => p.ListOfOperators)
                    .HasForeignKey(d => d.Film)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("listOfOperators_fk0");

                entity.HasOne(d => d.OperatorNavigation)
                    .WithMany(p => p.ListOfOperators)
                    .HasForeignKey(d => d.Operator)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("listOfOperators_fk1");
            });

            modelBuilder.Entity<ListOfPrizes>(entity =>
            {
                entity.ToTable("listOfPrizes");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Film).HasColumnName("film");

                entity.Property(e => e.Prize).HasColumnName("prize");

                entity.HasOne(d => d.FilmNavigation)
                    .WithMany(p => p.ListOfPrizes)
                    .HasForeignKey(d => d.Film)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("listOfPrizes_fk1");

                entity.HasOne(d => d.PrizeNavigation)
                    .WithMany(p => p.ListOfPrizes)
                    .HasForeignKey(d => d.Prize)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("listOfPrizes_fk0");
            });

            modelBuilder.Entity<ListOfProductions>(entity =>
            {
                entity.ToTable("listOfProductions");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Film).HasColumnName("film");

                entity.Property(e => e.Genre).HasColumnName("genre");

                entity.HasOne(d => d.FilmNavigation)
                    .WithMany(p => p.ListOfProductions)
                    .HasForeignKey(d => d.Film)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("listOfProductions_fk0");

                entity.HasOne(d => d.GenreNavigation)
                    .WithMany(p => p.ListOfProductions)
                    .HasForeignKey(d => d.Genre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("listOfProductions_fk1");
            });

            modelBuilder.Entity<Operator>(entity =>
            {
                entity.ToTable("operator");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("firstName")
                    .HasMaxLength(32);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("lastName")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Prize>(entity =>
            {
                entity.ToTable("prize");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Production>(entity =>
            {
                entity.ToTable("production");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Seance>(entity =>
            {
                entity.ToTable("seance");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Film).HasColumnName("film");

                entity.Property(e => e.Hall).HasColumnName("hall");

                entity.HasOne(d => d.FilmNavigation)
                    .WithMany(p => p.Seance)
                    .HasForeignKey(d => d.Film)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("seance_fk1");

                entity.HasOne(d => d.HallNavigation)
                    .WithMany(p => p.Seance)
                    .HasForeignKey(d => d.Hall)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("seance_fk0");
            });

            modelBuilder.Entity<UserRoles>(entity =>
            {
                entity.ToTable("userRoles");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(64);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("firstName")
                    .HasMaxLength(64);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("lastName")
                    .HasMaxLength(64);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(64);

                entity.Property(e => e.Role).HasColumnName("role");

                entity.Property(e => e.SecondName)
                    .IsRequired()
                    .HasColumnName("secondName")
                    .HasMaxLength(64);

                entity.HasOne(d => d.RoleNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.Role)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("role_pk");
            });

            modelBuilder.HasSequence("actor_id_seq");

            modelBuilder.HasSequence("area_id_seq");

            modelBuilder.HasSequence("cinema_id_seq");

            modelBuilder.HasSequence("cinemaCategory_id_seq");

            modelBuilder.HasSequence("cinemaStatus_id_seq");

            modelBuilder.HasSequence("director_id_seq");

            modelBuilder.HasSequence("film_id_seq");

            modelBuilder.HasSequence("genre_id_seq");

            modelBuilder.HasSequence("hall_id_seq");

            modelBuilder.HasSequence("hallList_id_seq");

            modelBuilder.HasSequence("listOfActors_id_seq");

            modelBuilder.HasSequence("listOfAreas_id_seq");

            modelBuilder.HasSequence("listOfCinemaCategories_id_seq");

            modelBuilder.HasSequence("listOfDirectors_id_seq");

            modelBuilder.HasSequence("listOfGenres_id_seq");

            modelBuilder.HasSequence("listOfOperators_id_seq");

            modelBuilder.HasSequence("listOfPrizes_id_seq");

            modelBuilder.HasSequence("listOfProductions_id_seq");

            modelBuilder.HasSequence("operator_id_seq");

            modelBuilder.HasSequence("prize_id_seq");

            modelBuilder.HasSequence("production_id_seq");

            modelBuilder.HasSequence("seance_id_seq");

            modelBuilder.HasSequence("userRoles_id_seq");

            modelBuilder.HasSequence("users_id_seq");
        }
    }
}