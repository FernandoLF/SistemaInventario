using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaInventario.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaInventario.AccesoDatos.Configuracion
{
    public class BodegaConfiguracion : IEntityTypeConfiguration<Bodega>
    {
        public void Configure(EntityTypeBuilder<Bodega> builder) {
            builder.ToTable("Bodega", "Inventario");

            builder.HasKey(x => x.IdBodega);
            builder.Property(x => x.IdBodega)
                .IsRequired();
            builder.Property(x => x.Nombre)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnType("NVARCHAR(60)");
            builder.Property(x => x.Descripcion)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("NVARCHAR(100)");
            builder.Property(x => x.Estado)
                .IsRequired();

            builder.HasQueryFilter(b => b.Estado);
        }
    }
}
