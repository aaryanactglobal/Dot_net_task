using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ASPCoreWebAPICRUD.Models;

public partial class CodeApiContext : DbContext
{
    public CodeApiContext()
    {
    }

    public CodeApiContext(DbContextOptions<CodeApiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Hotel> Hotels { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<RoomFacility> RoomFacilities { get; set; }

    public virtual DbSet<RoomStay> RoomStays { get; set; }

    public virtual DbSet<RoomStayFacility> RoomStayFacilities { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=LAPTOP-R2PEU393\\SQLEXPRESS;Database=CodeApi;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Hotel>(entity =>
        {
            entity.HasKey(e => e.HotelId).HasName("PK__Hotel__46023BDF3A5B0159");

            entity.ToTable("Hotel");

            entity.HasIndex(e => e.Code, "UQ__Hotel__A25C5AA7DEE93D00").IsUnique();

            entity.Property(e => e.HotelId).ValueGeneratedNever();
            entity.Property(e => e.AccommodationTypeCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CategoryCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CategoryGroupCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChainCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Coordinates)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CountryCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdate)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.License)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PostalCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StateCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Website)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.HasKey(e => e.RoomId).HasName("PK__Room__32863939E470B647");

            entity.ToTable("Room");

            entity.Property(e => e.RoomId).ValueGeneratedNever();
            entity.Property(e => e.CharacteristicCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RoomCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RoomType)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Hotel).WithMany(p => p.Rooms)
                .HasForeignKey(d => d.HotelId)
                .HasConstraintName("FK__Room__HotelId__3A81B327");
        });

        modelBuilder.Entity<RoomFacility>(entity =>
        {
            entity.HasKey(e => e.RoomFacilityId).HasName("PK__RoomFaci__E5FFD850B6D94E78");

            entity.ToTable("RoomFacility");

            entity.Property(e => e.RoomFacilityId).ValueGeneratedNever();
            entity.Property(e => e.FacilityCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FacilityGroupCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Voucher)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Room).WithMany(p => p.RoomFacilities)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("FK__RoomFacil__RoomI__3D5E1FD2");
        });

        modelBuilder.Entity<RoomStay>(entity =>
        {
            entity.HasKey(e => e.RoomStayId).HasName("PK__RoomStay__B2D2F2DB312867BB");

            entity.ToTable("RoomStay");

            entity.Property(e => e.RoomStayId).ValueGeneratedNever();
            entity.Property(e => e.StayType)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Room).WithMany(p => p.RoomStays)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("FK__RoomStay__RoomId__403A8C7D");
        });

        modelBuilder.Entity<RoomStayFacility>(entity =>
        {
            entity.HasKey(e => e.RoomStayFacilityId).HasName("PK__RoomStay__237609A40B71EFF5");

            entity.ToTable("RoomStayFacility");

            entity.Property(e => e.RoomStayFacilityId).ValueGeneratedNever();
            entity.Property(e => e.FacilityCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FacilityGroupCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.RoomStay).WithMany(p => p.RoomStayFacilities)
                .HasForeignKey(d => d.RoomStayId)
                .HasConstraintName("FK__RoomStayF__RoomS__4316F928");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
