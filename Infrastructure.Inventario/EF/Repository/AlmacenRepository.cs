using Domain.Inventario.Repositories;
using Domain.Ventas.Model.Almacen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Inventario.EF.Repository
{
    public class AlmacenRepository : IAlmacenRepository
    {
        public Task CreateAsync(Almacen obj)
        {
            throw new NotImplementedException();
        }

        public Task<Almacen?> FindByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
