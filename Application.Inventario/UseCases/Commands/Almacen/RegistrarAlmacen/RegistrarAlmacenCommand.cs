using Domain.Inventario.Model.Almacen;
using Domain.Inventario.ValueObjects;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Inventario.UseCases.Commands.Almacen.CreateAlmacen
{
    public record RegistrarAlmacenCommand : IRequest<Guid>
    {
        public string Descripcion { get; private set; }

        public CapacidadValue CapacidadMaxima { get; private set; }

        public string Latitud { get; private set; }

        public string Longitud { get; private set; }

        public ICollection<StockAlmacen> Stock{ get; set; }

        public RegistrarAlmacenCommand(string descripcion, long capacidadMaxima, string latitud, string longitud, ICollection<StockAlmacen> stock)
        {
            Descripcion = descripcion;
            CapacidadMaxima = capacidadMaxima;
            Latitud = latitud;
            Longitud = longitud;
            Stock = stock;
        }
    }
}
