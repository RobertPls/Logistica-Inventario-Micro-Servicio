using Application.Inventario.Dto;
using Application.Inventario.UseCases.Queries.Producto;
using Infrastructure.Inventario.EF.Config.Context;
using Infrastructure.Inventario.EF.ReadModel;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Inventario.Queries.Almacen
{
    internal class GetListaAlmacenHandler : IRequestHandler<GetListaAlmacenQuery, IEnumerable<AlmacenDto>>
    {
        private DbSet<AlmacenReadModel> Almacen;

        public GetListaAlmacenHandler(ReadDbContext dbContext)
        {
            Almacen = dbContext.Almacen;
        }
        public async Task<IEnumerable<AlmacenDto>> Handle(GetListaAlmacenQuery request, CancellationToken cancellationToken)
        {
            var query = Almacen.AsNoTracking().AsQueryable();

            query = query.Where(x=>x.CapacidadMaxima >= request.CapacidadMaximaSearchTerm);

            var lista = await query.Select(x => new AlmacenDto
            {
                AlmacenId = x.Id,
                Descripcion = x.Descripcion,
                CapacidadMaxima = x.CapacidadMaxima,
                Latitud = x.Latitud,
                Longitud = x.Longitud
            }).ToListAsync();
            return lista;

        }
    }
}
