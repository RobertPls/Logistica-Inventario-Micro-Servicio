using Infrastructure.Inventario.EF.Config.ReadConfig;
using Infrastructure.Inventario.EF.ReadModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Inventario.EF.Config.Context
{
    internal class ReadDbContext : DbContext
    //Add-Migration "InitialCreate" -OutputDir "EF/Migrations" -Context ReadDbContext
    //update-database -Context ReadDbContext
    //remove-migrations
    //update-database
    {
        public virtual DbSet<AlmacenReadModel> Almacen{ set; get; }
        public virtual DbSet<ProductoReadModel> Producto { set; get; }
        public virtual DbSet<StockAlmacenReadModel> StockAlmacen { set; get; }

        public ReadDbContext(DbContextOptions<ReadDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AlmacenReadConfig());
            modelBuilder.ApplyConfiguration(new ProductoReadConfig());
            modelBuilder.ApplyConfiguration(new StockAlmacenReadConfig());

        }
    }
}
