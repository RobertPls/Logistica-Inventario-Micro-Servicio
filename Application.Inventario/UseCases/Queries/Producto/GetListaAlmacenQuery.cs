using Application.Inventario.Dto;
using Domain.Inventario.ValueObjects;
using MediatR;

namespace Application.Inventario.UseCases.Queries.Producto
{
    public class GetListaAlmacenQuery : IRequest<IEnumerable<AlmacenDto>>
    {
        public long CapacidadMaximaSearchTerm { get; set; }

    }
}
