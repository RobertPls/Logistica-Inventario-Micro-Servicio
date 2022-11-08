using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Inventario.EF.ReadModel
{
    internal class ProductoReadModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

    }
}
