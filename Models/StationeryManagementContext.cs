using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StationeryManagementSystem.Models
{
    public partial class StationeryManagementContext : DbContext
    {
        public StationeryManagementContext()
        {
        }

        public StationeryManagementContext(DbContextOptions<StationeryManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Feedbacks> Feedbacks { get; set; }
        public virtual DbSet<RequestStationery> RequestStationery { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Stationeries> Stationeries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasKey(e => e.Idcategory);

                entity.HasIndex(e => e.NameCategory)
                    .HasName("UQ__Categori__40B862F44706E25B")
                    .IsUnique();

                entity.Property(e => e.Idcategory).HasColumnName("IDCategory");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NameCategory)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.HasKey(e => e.Iddepartment);

                entity.HasIndex(e => e.NameDepartment)
                    .HasName("UQ__Departme__C1DF207A54CD867D")
                    .IsUnique();

                entity.Property(e => e.Iddepartment)
                    .HasColumnName("IDDepartment")
                    .HasMaxLength(250)
                    .ValueGeneratedNever();

                entity.Property(e => e.DateCreate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NameDepartment)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.Idemployee);

                entity.HasIndex(e => e.EmailId)
                    .HasName("UQ__Employee__7ED91ACEC05C8777")
                    .IsUnique();

                entity.Property(e => e.Idemployee).HasColumnName("IDEmployee");

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.BirthDay).HasColumnType("date");

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Iddepartment)
                    .HasColumnName("IDDepartment")
                    .HasMaxLength(250);

                entity.Property(e => e.Idrole).HasColumnName("IDRole");

                entity.Property(e => e.NameEmployee)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.IddepartmentNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.Iddepartment)
                    .HasConstraintName("FK__Employees__IDDep__1920BF5C");

                entity.HasOne(d => d.IdroleNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.Idrole)
                    .HasConstraintName("FK__Employees__IDRol__1A14E395");
            });

            modelBuilder.Entity<Feedbacks>(entity =>
            {
                entity.HasKey(e => e.Idfeedback);

                entity.Property(e => e.Idfeedback).HasColumnName("IDFeedback");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Idemployee).HasColumnName("IDEmployee");

                entity.HasOne(d => d.IdemployeeNavigation)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.Idemployee)
                    .HasConstraintName("FK__Feedbacks__IDEmp__2A4B4B5E");
            });

            modelBuilder.Entity<RequestStationery>(entity =>
            {
                entity.HasKey(e => e.IdrequestStationery);

                entity.Property(e => e.IdrequestStationery).HasColumnName("IDRequestStationery");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Idemployee).HasColumnName("IDEmployee");

                entity.Property(e => e.Idstationerie).HasColumnName("IDStationerie");

                entity.HasOne(d => d.IdemployeeNavigation)
                    .WithMany(p => p.RequestStationery)
                    .HasForeignKey(d => d.Idemployee)
                    .HasConstraintName("FK__RequestSt__IDEmp__25869641");

                entity.HasOne(d => d.IdstationerieNavigation)
                    .WithMany(p => p.RequestStationery)
                    .HasForeignKey(d => d.Idstationerie)
                    .HasConstraintName("FK__RequestSt__IDSta__267ABA7A");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.Idrole);

                entity.HasIndex(e => e.RoleName)
                    .HasName("UQ__Roles__8A2B6160D2A47959")
                    .IsUnique();

                entity.Property(e => e.Idrole).HasColumnName("IDRole");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Stationeries>(entity =>
            {
                entity.HasKey(e => e.Idstationerie);

                entity.HasIndex(e => e.NameStationerie)
                    .HasName("UQ__Statione__086D799DA94FEB95")
                    .IsUnique();

                entity.Property(e => e.Idstationerie).HasColumnName("IDStationerie");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Idcategory).HasColumnName("IDCategory");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.NameStationerie)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UnitOfMeasure)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.IdcategoryNavigation)
                    .WithMany(p => p.Stationeries)
                    .HasForeignKey(d => d.Idcategory)
                    .HasConstraintName("FK__Stationer__IDCat__22AA2996");
            });
        }
    }
}
