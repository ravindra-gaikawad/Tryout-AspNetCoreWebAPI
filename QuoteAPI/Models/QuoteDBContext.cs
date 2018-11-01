namespace QuoteAPI.Models
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Options;

    public partial class QuoteDBContext : DbContext
    {
        private readonly AppSettings appSettings;

        public QuoteDBContext(IOptions<AppSettings> settings)
        {
            this.appSettings = settings.Value;
        }

        public virtual DbSet<Author> Author { get; set; }

        public virtual DbSet<Category> Category { get; set; }

        public virtual DbSet<Quote> Quote { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.appSettings.QuoteDBConnectionString);
        }

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
