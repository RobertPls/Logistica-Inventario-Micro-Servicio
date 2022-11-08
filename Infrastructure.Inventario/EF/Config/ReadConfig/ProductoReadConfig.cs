using Infrastructure.Inventario.EF.ReadModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Inventario.EF.Config.ReadConfig
{
    internal class ProductoReadConfig : IEntityTypeConfiguration<ProductoReadModel>
    {
        public void Configure(EntityTypeBuilder<ProductoReadModel> builder)
        {
            builder.ToTable("Producto");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("productoId");
            builder.Property(x => x.Nombre).HasColumnName("nombreProducto").IsRequired();
            builder.Property(x => x.Precio).HasColumnName("precio").HasPrecision(14,2);
        }
    }
}
