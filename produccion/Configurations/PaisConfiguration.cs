using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using produccion.Entities;

namespace produccion.Configurations;

public class PaisConfiguration : IEntityTypeConfiguration<Pais>
{
    public void Configure(EntityTypeBuilder<Pais> builder)
    {

        builder.ToTable("pais");

        builder.HasKey(e => e.Id).HasName("PRIMARY");


        builder.Property(e => e.Nombre)
            .HasMaxLength(50)
            .HasColumnName("nombre");
    } 
} 