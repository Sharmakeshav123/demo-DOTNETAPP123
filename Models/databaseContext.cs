using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace InventoryManagement.Models
{
    public partial class databaseContext : DbContext
    {
        public databaseContext()
        {
        }

        public databaseContext(DbContextOptions<databaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Table> Table { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
//#warning// To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //        optionsBuilder.UseSqlServer("Server=;Database=database;Integrated Security=True");
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__Products__B40CC6ED3FAC89C9");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Table>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__Table__B40CC6ED8B48FF25");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 0)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
