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
    internal class StockAlmacenReadConfig : IEntityTypeConfiguration<StockAlmacenReadModel>
    {
        public void Configure(EntityTypeBuilder<StockAlmacenReadModel> builder)
        {
            builder.ToTable("StockAlmacen");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("stockAlmacenId");
            builder.Property(x => x.Cantidad).HasColumnName("cantidad").HasDefaultValue(0);
            builder.Property(x => x.ProductoId).HasColumnName("productoId").IsRequired();
            builder.Property(x => x.AlmacenId).HasColumnName("almacenId").IsRequired();
            builder.HasOne(x => x.Almacen).WithMany().HasForeignKey(x => x.AlmacenId);
            builder.HasOne(x => x.Producto).WithMany().HasForeignKey(x => x.ProductoId);
        }
    }
}
