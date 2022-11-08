using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Inventario.EF.ReadModel
{
    internal class AlmacenReadModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Descripcion { get; set; }

        public long CapacidadMaxima { get; set; }

        public string Latitud { get; set; }

        public string Longitud { get; set; }

        public ICollection<StockAlmacenReadModel> Stock { get; set; }
    }
}
