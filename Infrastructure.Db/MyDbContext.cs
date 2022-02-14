using DynamicLoadingApp.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace DynamicLoadingApp.Infrastructure.Db
{
    public class MyDbContext : DbContext
    {
        public DbSet<Comment> Comment { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=data.sqlite3");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("wp_comments");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("comment_ID").IsRequired();
                entity.Property(e => e.Author).HasColumnName("comment_author").IsRequired();
                entity.Property(e => e.Email).HasColumnName("comment_author_email").IsRequired();
                entity.Property(e => e.Url).HasColumnName("comment_author_url").IsRequired();
                entity.Property(e => e.DateGmt).HasColumnName("comment_date_gmt").IsRequired();
                entity.Property(e => e.Content).HasColumnName("comment_content").IsRequired();
                entity.Property(e => e.Approved).HasColumnName("comment_approved").IsRequired();
            });
        }
    }
}