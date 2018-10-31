﻿namespace QuoteAPI.Models
{
    using Microsoft.EntityFrameworkCore;

    public partial class QuoteDBContext : DbContext
    {
        public QuoteDBContext()
        {
        }

        public QuoteDBContext(DbContextOptions<QuoteDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Author { get; set; }

        public virtual DbSet<Category> Category { get; set; }

        public virtual DbSet<Quote> Quote { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Quote>(entity =>
            {
                entity.Property(e => e.Author).HasMaxLength(50);

                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(4000);
            });
        }
    }
}
