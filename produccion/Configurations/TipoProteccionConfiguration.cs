using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using produccion.Entities;

namespace produccion.Configurations;

public class TipoProteccionConfiguration : IEntityTypeConfiguration<TipoProteccion>
{
    public void Configure(EntityTypeBuilder<TipoProteccion> builder)
    {
        builder.ToTable("tipo_proteccion");

        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.Property(e => e.Descripcion).HasMaxLength(50);
    } 
} 