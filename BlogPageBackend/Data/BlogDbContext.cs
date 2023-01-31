using BlogPageBackend.Data.Entities;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace BlogPageBackend.Data
{
    public class BlogDbContext : DbContext
    {
      
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Like>();
            modelBuilder.Entity<Role>();
            modelBuilder.Entity<User>();
            modelBuilder.Entity<Post>();
            modelBuilder.Entity<Comment>();
        }
        public DbSet<User> User { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Like> Like { get; set; }
        public DbSet<Comment> Comment { get; set; }
    }
}
