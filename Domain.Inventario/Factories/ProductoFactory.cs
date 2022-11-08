using Domain.Inventario.Model.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Inventario.Factories
{
    public class ProductoFactory : IProductoFactory
    {
        public Producto Crear(string nombre, decimal precio)
        {
            return new Producto(nombre, precio);
        }
    }
}
