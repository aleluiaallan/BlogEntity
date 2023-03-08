using BlogEntity.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogEntity.Data
{
    public class BlogDataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        //public DbSet<PostTag> PostsTags { get; set; }
        public DbSet<User> Users { get; set; }
        //public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=localhost,1433;Database=BLOG;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;");
            options.LogTo(Console.WriteLine); //lista as querys executadas direto no console
        }

    }
}