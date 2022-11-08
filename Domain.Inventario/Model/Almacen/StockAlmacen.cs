using ShareKernel.Core;
using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Inventario.Model.Almacen
{
    public class StockAlmacen : Entity<Guid>
    {
        public Guid ProductoId { get; private set; }

        public CantidadValue Cantidad { get; private set; }

        public StockAlmacen(Guid productoId, int stock)
        {
            if (productoId == Guid.Empty)
            {
                throw new ArgumentException("El producto no puede ser vacio");
            }

            Id = Guid.NewGuid();
            ProductoId = productoId;
            Cantidad = stock;
        }

        public void DisminuirStock(int cantidad)
        {
            if (Cantidad - cantidad < 0)
            {
                throw new BussinessRuleValidationException("No hay stock suficiente");
            }
            Cantidad = Cantidad - cantidad;
        }
    }
}
