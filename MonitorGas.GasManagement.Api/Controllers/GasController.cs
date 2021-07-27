using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonitorGas.GasManagement.Application.Features.Gases.Command.CreateGas;
using MonitorGas.GasManagement.Application.Features.Gases.Command.DeleteGas;
using MonitorGas.GasManagement.Application.Features.Gases.Command.UpdateGas;
using MonitorGas.GasManagement.Application.Features.Gases.Queries.GetGasDetails;
using MonitorGas.GasManagement.Application.Features.Gases.Queries.GetGasList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class GasController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GasController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = "GetAllGas")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<List<GasListVm>>> GetAllEvents()
        {
            var dtos = await _mediator.Send(new GetGasListQuery());
            return Ok(dtos);
        }

        [HttpGet("{id}", Name = "GetGasById")]
        public async Task<ActionResult<GasDetailsVm>> GetEventById(Guid id)
        {
            var getEventDetailQuery = new GetGasDetailQuery() { Id = id };
            return Ok(await _mediator.Send(getEventDetailQuery));
        }

        [HttpPost(Name = "AddGas")]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateGasCommand createGasCommand)
        {
            var id = await _mediator.Send(createGasCommand);
            return Ok(id);
        }

        [HttpPut(Name = "UpdateGas")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Update([FromBody] UpdateGasCommand updateGasCommand)
        {
            await _mediator.Send(updateGasCommand);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteGas")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(Guid id)
        {
            var deleteGasCommand = new DeleteGasCommand() { GasID = id };
            await _mediator.Send(deleteGasCommand);
            return NoContent();
        }
    }
}
