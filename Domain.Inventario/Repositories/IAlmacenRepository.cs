
using Domain.Ventas.Model.Almacen;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Inventario.Repositories
{
    public interface IAlmacenRepository : IRepository<Almacen, Guid>
    {
    }
}
