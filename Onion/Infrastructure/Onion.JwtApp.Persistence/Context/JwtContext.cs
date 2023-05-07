using Microsoft.EntityFrameworkCore;
using Onion.JwtApp.Domain.Entities;
using System.Reflection;

namespace Onion.JwtApp.Persistence.Context
{
    public class JwtContext : DbContext
    {
        public JwtContext(DbContextOptions<JwtContext> options) : base(options)
        {
        }

        public DbSet<AppRole>? AppRoles { get; set; }
        public DbSet<AppUser>? AppUsers { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Product>? Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
