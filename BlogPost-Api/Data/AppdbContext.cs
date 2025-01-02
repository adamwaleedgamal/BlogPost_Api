using BlogPost_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogPost_Api.Data
{
    public class AppdbContext : DbContext
    {
        public AppdbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Reaction> Reactions { get; set; }

    }
}
