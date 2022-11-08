using Application.Inventario.UseCases.Commands.Almacen.CreateAlmacen;
using Application.Inventario.UseCases.Queries.Producto;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Inventario.Controllers.Inventario
{
    // api/inventario
    [Route("api/almacen")]
    [ApiController]
    public class AlmacenController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AlmacenController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("search")]
        [HttpGet]
        public async Task<IActionResult> SearchAlmacen([FromBody] long capacidadMaxima = 0)
        {
            var query = new GetListaAlmacenQuery
            {
                CapacidadMaximaSearchTerm = capacidadMaxima
            };
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
