
using SharedKernel.ValueObjects;
using ShareKernel.Core;
using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Inventario.Model.Producto
{
    public class Producto : AggregateRoot<Guid>
    {
        public ProductoNombreValue Nombre { get; private set; }
        public PrecioValue Precio { get; private set; }

        public Producto(string nombre, decimal precio)
        {
            Id = Guid.NewGuid();
            Nombre = nombre;
            Precio = precio;
        }

        public void EditarNombre(string nombre)
        {
            Nombre = nombre;
        }
        public void EditarPrecio(decimal precio)
        {
            Precio = precio;
        }
    }
}
