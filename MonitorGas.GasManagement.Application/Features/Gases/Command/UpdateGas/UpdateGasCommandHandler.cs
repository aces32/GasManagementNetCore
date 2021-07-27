using AutoMapper;
using MediatR;
using MonitorGas.GasManagement.Application.Contracts.Persistence;
using MonitorGas.GasManagement.Application.Exceptions;
using MonitorGas.GasManagement.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.Application.Features.Gases.Command.UpdateGas
{
    public class UpdateGasCommandhandler : IRequestHandler<UpdateGasCommand>
    {
        private readonly IAsyncRepository<Gas> _gasRepository;
        private readonly IMapper _mapper;

        public UpdateGasCommandhandler(IMapper mapper, IAsyncRepository<Gas> gasRepository)
        {
            _mapper = mapper;
            _gasRepository = gasRepository;
        }

        public async Task<Unit> Handle(UpdateGasCommand request, CancellationToken cancellationToken)
        {
            var gasToUpdate = await _gasRepository.GetByIdAsync(request.GasID);

            if (gasToUpdate == null)
            {
                throw new NotFoundException(nameof(Gas), request.GasID);
            }

            var validator = new UpdateGasCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            _mapper.Map(request, gasToUpdate, typeof(UpdateGasCommand), typeof(Gas));

            await _gasRepository.UpdateAsync(gasToUpdate);

            return Unit.Value;
        }
    }
}
