using Application.Inventario.UseCases.Commands.Almacen.CreateAlmacen;
using Domain.Inventario.Factories;
using Domain.Inventario.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Inventario.UseCases.Commands.Almacen.RegistrarAlmacen
{
    internal class RegistrarAlmacenHandler : IRequestHandler<RegistrarAlmacenCommand, Guid>
    {
        private readonly IAlmacenRepository _almacenRepository;
        private readonly IAlmacenFactory _almacenFactory;

        public RegistrarAlmacenHandler(IAlmacenRepository almacenRepository, IAlmacenFactory almacenFactory)
        {
            _almacenRepository = almacenRepository;
            _almacenFactory = almacenFactory;
        }

        public async Task<Guid> Handle(RegistrarAlmacenCommand request, CancellationToken cancellationToken)
        {
            var almacen = _almacenFactory.Crear(request.Descripcion, request.CapacidadMaxima, request.Latitud, request.Longitud);
            foreach (var item in request.Stock)
            {
                almacen.AgregarStockAlmacen(item.ProductoId, item.Cantidad);
            }
            await _almacenRepository.CreateAsync(almacen);
            return almacen.Id;
        }
    }
}
