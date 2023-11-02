using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using produccion.Entities;

namespace produccion.Configurations;

public class TipoEstadoConfiguration : IEntityTypeConfiguration<TipoEstado>
{
    public void Configure(EntityTypeBuilder<TipoEstado> builder)
    {

        builder.ToTable("tipo_estado");

        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.Property(e => e.Descripcion).HasMaxLength(50);
    } 
} 