using Domain.Inventario.Model.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Inventario.Factories
{
    public interface IProductoFactory
    {
        Producto Crear(string nombre, decimal precio);

    }
}
