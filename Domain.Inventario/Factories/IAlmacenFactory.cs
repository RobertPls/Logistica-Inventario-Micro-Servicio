using Domain.Ventas.Model.Almacen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Inventario.Factories
{
    public interface IAlmacenFactory
    {
        Almacen Crear(string descripcion, long capacidadMaxima, string latitud, string longitud);

    }
}
