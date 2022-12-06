using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EmployeeSignIn.Models
{
    public partial class EmployeeSigningSystemContext : DbContext
    {
        public EmployeeSigningSystemContext()
        {
        }

        public EmployeeSigningSystemContext(DbContextOptions<EmployeeSigningSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EmpDetails> EmpDetails { get; set; }
        public virtual DbSet<EmployeeTempBadge> EmployeeTempBadge { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=HSHLT-1694\\SQLEXPRESS01;Database=EmployeeSigningSystem;Trusted_Connection=True; trustservercertificate = true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmpDetails>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EmpFirstname)
                    .IsRequired()
                    .HasColumnName("empFirstname")
                    .HasMaxLength(50);

                entity.Property(e => e.EmpLastname)
                    .IsRequired()
                    .HasColumnName("empLastname")
                    .HasMaxLength(50);

                entity.Property(e => e.Photo)
                    .IsRequired()
                    .HasColumnName("photo")
                    .HasColumnType("image");
            });

            modelBuilder.Entity<EmployeeTempBadge>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(10);

                entity.Property(e => e.AssignT).HasColumnType("datetime");

                entity.Property(e => e.EmployeeFirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeLastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SignInT).HasColumnType("datetime");

                entity.Property(e => e.SignOutT).HasColumnType("datetime");

                entity.Property(e => e.TempBadge)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
