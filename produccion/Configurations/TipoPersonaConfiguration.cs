using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using produccion.Entities;

namespace produccion.Configurations;

public class TipoPersonaConfiguration : IEntityTypeConfiguration<TipoPersona>
{
    public void Configure(EntityTypeBuilder<TipoPersona> builder)
    {
        builder.ToTable("tipo_persona");

        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.Property(e => e.Nombre).HasMaxLength(50);
    } 
} 