using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TvAzteca.Core.Entities;

namespace TvAzteca.Data.Configurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder
                .HasKey(x => x.UsuarioId);

            builder
                .Property(x => x.UsuarioId)
                .UseOracleIdentityColumn();

            builder
                .Property(x => x.Nombre)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(x => x.Apellido)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(x => x.Birthday)
                .IsRequired();

            builder
                .Property(x => x.Pass)
                .IsRequired();
        }
    }
}
