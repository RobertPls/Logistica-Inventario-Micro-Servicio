using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Inventario.EF.ReadModel
{
    internal class StockAlmacenReadModel
    {
        [Key]
        public Guid Id { get; set; }
        public int Cantidad { get; set; }


        public Guid ProductoId { get;  set; }

        public Guid AlmacenId { get; set; }

        public ProductoReadModel Producto { get; set; }

        public AlmacenReadModel Almacen { get; set; }

    }
}
