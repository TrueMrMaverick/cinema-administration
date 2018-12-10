using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HotelAdministation.Models
{
    public partial class hotelContext : DbContext
    {
        public hotelContext()
        {
        }

        public hotelContext(DbContextOptions<hotelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CheckInList> CheckInList { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<DbLog> DbLog { get; set; }
        public virtual DbSet<Floor> Floor { get; set; }
        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<RoomType> RoomType { get; set; }
        public virtual DbSet<StaffMember> StaffMember { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=localhost;Database=hotel;Username=postgres;Password=gjyjvfhtdf7");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CheckInList>(entity =>
            {
                entity.ToTable("checkInList");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Customer).HasColumnName("customer");

                entity.Property(e => e.DateOfArrival)
                    .HasColumnName("dateOfArrival")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Room).HasColumnName("room");

                entity.HasOne(d => d.CustomerNavigation)
                    .WithMany(p => p.CheckInList)
                    .HasForeignKey(d => d.Customer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("checkInList_fk1");

                entity.HasOne(d => d.RoomNavigation)
                    .WithMany(p => p.CheckInList)
                    .HasForeignKey(d => d.Room)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("checkInList_fk0");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("firstName")
                    .HasMaxLength(32);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("lastName")
                    .HasMaxLength(32);

                entity.Property(e => e.PassportId).HasColumnName("passportId");

                entity.Property(e => e.SecondName)
                    .IsRequired()
                    .HasColumnName("secondName")
                    .HasMaxLength(32);

                entity.Property(e => e.Town)
                    .IsRequired()
                    .HasColumnName("town")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<DbLog>(entity =>
            {
                entity.ToTable("dbLog");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Action).HasColumnName("action");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.RowId).HasColumnName("rowId");

                entity.Property(e => e.TableName)
                    .HasColumnName("tableName")
                    .HasMaxLength(64);

                entity.Property(e => e.TriggerName).HasColumnName("triggerName");
            });

            modelBuilder.Entity<Floor>(entity =>
            {
                entity.ToTable("floor");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.Room).HasColumnName("room");

                entity.Property(e => e.StaffMember).HasColumnName("staffMember");

                entity.HasOne(d => d.RoomNavigation)
                    .WithMany(p => p.Floor)
                    .HasForeignKey(d => d.Room)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("floor_fk0");

                entity.HasOne(d => d.StaffMemberNavigation)
                    .WithMany(p => p.Floor)
                    .HasForeignKey(d => d.StaffMember)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("floor_fk1");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.ToTable("room");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.PhoneNumber).HasColumnName("phoneNumber");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.Room)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("room_fk0");
            });

            modelBuilder.Entity<RoomType>(entity =>
            {
                entity.ToTable("roomType");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(16);
            });

            modelBuilder.Entity<StaffMember>(entity =>
            {
                entity.ToTable("staffMember");

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

                entity.Property(e => e.SecondName)
                    .IsRequired()
                    .HasColumnName("secondName")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("userRole");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
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
                    .HasConstraintName("users_fk0");
            });

            modelBuilder.HasSequence("checkInList_id_seq");

            modelBuilder.HasSequence("customer_id_seq");

            modelBuilder.HasSequence("dbLog_id_seq");

            modelBuilder.HasSequence("room_id_seq");

            modelBuilder.HasSequence("staffMember_id_seq");

            modelBuilder.HasSequence("users_id_seq");
        }
    }
}
