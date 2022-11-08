
using Domain.Inventario.Model.Almacen;
using Domain.Inventario.ValueObjects;
using ShareKernel.Core;
using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Ventas.Model.Almacen
{
    public class Almacen : AggregateRoot<Guid>
    {
        public DescripcionValue Descripcion { get; private set; }
        
        public CapacidadValue CapacidadMaxima { get; private set; }       
        
        public string Latitud { get; private set; }
        
        public string Longitud { get; private set; }

        private readonly ICollection<StockAlmacen> _stock;
        
        public IEnumerable<StockAlmacen> StockAlmacen
        {
            get { return _stock; }
        }


        internal Almacen(string descripcion, long capacidadMaxima,string latitud, string longitud)
        {
            Id = Guid.NewGuid();
            _stock = new List<StockAlmacen>();
            Descripcion = descripcion;
            CapacidadMaxima = capacidadMaxima;
            Latitud = latitud;
            Longitud = longitud;

        }

        public void AgregarStockAlmacen(Guid productoId, int cantidad)
        {
            var stockAlmacen = new StockAlmacen(productoId, cantidad);
            _stock.Add(stockAlmacen);
        }

        public void EditarDescripcion(string descripcion)
        {
            Descripcion = descripcion;
        }
        public void EditarCapacidadMaxima(long capacidadMaxima)
        {
            CapacidadMaxima = capacidadMaxima;
        }

        public void EditarLatitud(string latitud)
        {
            Latitud = latitud;
        }

        public void EditarLongitud(string longitud)
        {
            Longitud = longitud;
        }
    }
}
