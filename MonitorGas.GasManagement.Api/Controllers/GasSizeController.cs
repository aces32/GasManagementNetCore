using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonitorGas.GasManagement.Application.Features.GasSizes.Command.CreateGasSizes;
using MonitorGas.GasManagement.Application.Features.GasSizes.Queries.GasSizesList;
using MonitorGas.GasManagement.Application.Features.GasSizes.Queries.GasSizesListsWithGases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class GasSizeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GasSizeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllGasSizes")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<GasSizeListVm>>> GetAllGasSizes()
        {
            var dtos = await _mediator.Send(new GasSizesListQuery());
            return Ok(dtos);
        }

        [HttpGet("allwithGases", Name = "GetAllGasSizesWithGases")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<GasSizesListsWithGasesVm>>> GetAllGasSizesWithGases(bool includeHistory)
        {
            GetGasSizesListsWithGasesQuery getGasSizesListsWithGasesQuery = new() { IncludeHistory = includeHistory };
            var dtos = await _mediator.Send(getGasSizesListsWithGasesQuery);
            return Ok(dtos);
        }

        [HttpPost(Name = "AddGasSize")]
        public async Task<ActionResult<CreateGasSizeCommandResponse>> Create([FromBody] CreateGasSizeCommand createGasSizeCommand)
        {
            var response = await _mediator.Send(createGasSizeCommand);
            return Ok(response);
        }
    }
}
