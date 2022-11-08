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
    internal class AlmacenReadConfig : IEntityTypeConfiguration<AlmacenReadModel>
    {
        public void Configure(EntityTypeBuilder<AlmacenReadModel> builder)
        {
            builder.ToTable("Almacen");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("almacenId");
            builder.Property(x => x.Descripcion).HasColumnName("descripcion");
            builder.Property(x => x.CapacidadMaxima).HasColumnName("capacidadMaxima").HasDefaultValue(0);
            builder.Property(x => x.Latitud).HasColumnName("latitud");
            builder.Property(x => x.Longitud).HasColumnName("longitud");
            builder.HasMany(x => x.Stock).WithOne(x => x.Almacen).HasForeignKey(x => x.AlmacenId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
