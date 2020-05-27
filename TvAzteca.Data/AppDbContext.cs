using Microsoft.EntityFrameworkCore;
using TvAzteca.Core.Entities;
using TvAzteca.Data.Configurations;

namespace TvAzteca.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .ApplyConfiguration(new UsuarioConfiguration());
        }
    }
}
