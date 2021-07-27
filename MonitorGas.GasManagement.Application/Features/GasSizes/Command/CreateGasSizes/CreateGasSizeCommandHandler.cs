using AutoMapper;
using MediatR;
using MonitorGas.GasManagement.Application.Contracts.Persistence;
using MonitorGas.GasManagement.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.Application.Features.GasSizes.Command.CreateGasSizes
{
    public class CreateGasSizeCommandHandler : IRequestHandler<CreateGasSizeCommand, CreateGasSizeCommandResponse>
    {
        private readonly IAsyncRepository<GasSize> _gasSizeRepository;
        private readonly IMapper _mapper;

        public CreateGasSizeCommandHandler(IMapper mapper, IAsyncRepository<GasSize> gasSizeRepository)
        {
            _mapper = mapper;
            _gasSizeRepository = gasSizeRepository;
        }
        public async Task<CreateGasSizeCommandResponse> Handle(CreateGasSizeCommand request, CancellationToken cancellationToken)
        {
            var createGasSizeCommandResponse = new CreateGasSizeCommandResponse();

            var validator = new CreateGasSizeCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                createGasSizeCommandResponse.Success = false;
                createGasSizeCommandResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    createGasSizeCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if (createGasSizeCommandResponse.Success)
            {
                var gasSize = new GasSize() { SizeInKg = request.SizeInKg };
                gasSize = await _gasSizeRepository.AddAsync(gasSize);
                createGasSizeCommandResponse.GasSize = _mapper.Map<CreateGasSizeDto>(gasSize);
            }

            return createGasSizeCommandResponse;
        }
    }
}
