using Domain.Ventas.Model.Almacen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Inventario.Factories
{
    public class AlmacenFactory : IAlmacenFactory
    {
        public Almacen Crear(string descripcion, long capacidadMaxima, string latitud, string longitud)
        {
            return new Almacen(descripcion,  capacidadMaxima,  latitud,  longitud);
        }

    }
}
