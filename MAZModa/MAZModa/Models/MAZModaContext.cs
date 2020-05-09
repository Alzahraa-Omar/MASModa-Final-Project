using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MAZModa.Models
{
    public partial class MAZModaContext : DbContext
    {
        public MAZModaContext()
        {
        }

        public MAZModaContext(DbContextOptions<MAZModaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Age> Age { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<DressCode> DressCode { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Heights> Heights { get; set; }
        public virtual DbSet<Note> Note { get; set; }
        public virtual DbSet<Photo> Photo { get; set; }
        public virtual DbSet<Shop> Shop { get; set; }
        public virtual DbSet<Style> Style { get; set; }
        public virtual DbSet<StyleShop> StyleShop { get; set; }
        public virtual DbSet<Tailor> Tailor { get; set; }
        public virtual DbSet<TailorPhoto> TailorPhoto { get; set; }
        public virtual DbSet<Weights> Weights { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(local);Database=MAZModa;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Age>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BetweenAge).HasMaxLength(25);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(25);
            });

            modelBuilder.Entity<DressCode>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(25);
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(6);
            });

            modelBuilder.Entity<Heights>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BetweenHeight).HasMaxLength(25);
            });

            modelBuilder.Entity<Note>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Style)
                    .WithMany(p => p.Photo)
                    .HasForeignKey(d => d.StyleId)
                    .HasConstraintName("StylePhotoFK");
            });

            modelBuilder.Entity<Shop>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Location).HasColumnName("location");

                entity.Property(e => e.Name).HasMaxLength(25);
            });

            modelBuilder.Entity<Style>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Age)
                    .WithMany(p => p.Style)
                    .HasForeignKey(d => d.AgeId)
                    .HasConstraintName("AFK");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Style)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("CatFK");

                entity.HasOne(d => d.DressCode)
                    .WithMany(p => p.Style)
                    .HasForeignKey(d => d.DressCodeId)
                    .HasConstraintName("DCFK");

                entity.HasOne(d => d.Height)
                    .WithMany(p => p.Style)
                    .HasForeignKey(d => d.HeightId)
                    .HasConstraintName("HFK");

                entity.HasOne(d => d.Weight)
                    .WithMany(p => p.Style)
                    .HasForeignKey(d => d.WeightId)
                    .HasConstraintName("WFK");
            });

            modelBuilder.Entity<StyleShop>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.StyleShop)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("ShopFK");

                entity.HasOne(d => d.Style)
                    .WithMany(p => p.StyleShop)
                    .HasForeignKey(d => d.StyleId)
                    .HasConstraintName("StyleShopFK");
            });

            modelBuilder.Entity<Tailor>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(25);
            });

            modelBuilder.Entity<TailorPhoto>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Tailor)
                    .WithMany(p => p.TailorPhoto)
                    .HasForeignKey(d => d.TailorId)
                    .HasConstraintName("TailorPhotoFK");
            });

            modelBuilder.Entity<Weights>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BetweenWeight).HasMaxLength(25);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
