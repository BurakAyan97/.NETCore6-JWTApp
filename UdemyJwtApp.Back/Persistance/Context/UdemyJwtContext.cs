using Microsoft.EntityFrameworkCore;
using System.Reflection;
using UdemyJwtApp.Back.Core.Domain;

namespace UdemyJwtApp.Back.Persistance.Context
{
    public class UdemyJwtContext : DbContext
    {
        public UdemyJwtContext(DbContextOptions<UdemyJwtContext> options) : base(options)
        {
        }

        public DbSet<AppRole> AppRoles => this.Set<AppRole>();
        public DbSet<AppUser> AppUsers => this.Set<AppUser>();
        public DbSet<Category> Categories => this.Set<Category>();
        public DbSet<Product> Products => this.Set<Product>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
