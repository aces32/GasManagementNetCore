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

namespace MonitorGas.GasManagement.Application.Features.Gases.Command.DeleteGas
{
    public class DeleteGasCommandHandler : IRequestHandler<DeleteGasCommand>
    {
        private readonly IAsyncRepository<Gas> _gasRepository;
        private readonly IMapper _mapper;
        public DeleteGasCommandHandler(IMapper mapper, IAsyncRepository<Gas> gasRepository)
        {
            _mapper = mapper;
            _gasRepository = gasRepository;
        }

        public async Task<Unit> Handle(DeleteGasCommand request, CancellationToken cancellationToken)
        {
            var gasToDelete = await _gasRepository.GetByIdAsync(request.GasID);

            if (gasToDelete == null)
            {
                throw new NotFoundException(nameof(Gas), request.GasID);
            }

            await _gasRepository.DeleteAsync(gasToDelete);

            return Unit.Value;
        }
    }
}
