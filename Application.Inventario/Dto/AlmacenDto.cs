using Domain.Inventario.ValueObjects;
using MediatR.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Inventario.Dto
{
    public class AlmacenDto
    {
        public Guid AlmacenId { get; set; }

        public string Descripcion { get; set; }

        public CapacidadValue CapacidadMaxima { get; set; }

        public string Latitud { get; set; }

        public string Longitud { get;  set; }

    }
}
