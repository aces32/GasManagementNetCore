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

namespace MonitorGas.GasManagement.Application.Features.Gases.Queries.GetGasDetails
{
    public class GetGasDetailsQueryHandler : IRequestHandler<GetGasDetailQuery, GasDetailsVm>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Gas> _gasRepository;
        private readonly IAsyncRepository<GasSize> _gasSizeRepository;

        public GetGasDetailsQueryHandler(IMapper mapper, IAsyncRepository<Gas> gasRepository, IAsyncRepository<GasSize> gasSizeRepository)
        {
            _mapper = mapper;
            _gasRepository = gasRepository;
            _gasSizeRepository = gasSizeRepository;
        }
        public async Task<GasDetailsVm> Handle(GetGasDetailQuery request, CancellationToken cancellationToken)
        {
            var gas = await _gasRepository.GetByIdAsync(request.Id);
            var gasDetailDto = _mapper.Map<GasDetailsVm>(gas);

            var gasSizes = await _gasSizeRepository.GetByIdAsync(gas.GasSizeID);
            if (gasSizes == null)
            {
                throw new NotFoundException(nameof(Gas), request.Id);
            }

            gasDetailDto.GasSize = _mapper.Map<GasSizeDto>(gasSizes);

            return gasDetailDto;

        }
    }
}
