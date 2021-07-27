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

namespace MonitorGas.GasManagement.Application.Features.Gases.Queries.GetGasList
{
    public class GetGasListQueryHandler : IRequestHandler<GetGasListQuery, List<GasListVm>>
    {
        private readonly IAsyncRepository<Gas> _gasRepository;
        private readonly IMapper _mapper;
        public GetGasListQueryHandler(IMapper mapper, IAsyncRepository<Gas> gasRepository)
        {
            _mapper = mapper;
            _gasRepository = gasRepository;
        }
        public async Task<List<GasListVm>> Handle(GetGasListQuery request, CancellationToken cancellationToken)
        {
            var allGas = (await _gasRepository.ListAllAsync()).OrderBy(x => x.Date);
            return _mapper.Map<List<GasListVm>>(allGas);
        }
    }
}
