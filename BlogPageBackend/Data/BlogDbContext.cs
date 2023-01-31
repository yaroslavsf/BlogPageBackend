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
        public DbSet<User>? Users;
        public DbSet<Role>? Roles;
        public DbSet<Post>? Posts;
        public DbSet<Comment>? Comments;
        public DbSet<Like>? Likes;
        public DbSet<BlogPageBackend.Data.Entities.User> User { get; set; }
        public DbSet<BlogPageBackend.Data.Entities.Post> Post { get; set; }
        public DbSet<BlogPageBackend.Data.Entities.Like> Like { get; set; }
        public DbSet<BlogPageBackend.Data.Entities.Comment> Comment { get; set; }
    }
}
