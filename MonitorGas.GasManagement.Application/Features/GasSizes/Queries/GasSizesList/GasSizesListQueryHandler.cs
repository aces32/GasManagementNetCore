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

namespace MonitorGas.GasManagement.Application.Features.GasSizes.Queries.GasSizesList
{
    public class GasSizesListQueryHandler : IRequestHandler<GasSizesListQuery, List<GasSizeListVm>>
    {
        private readonly IAsyncRepository<GasSize> _gasSizeRepository;
        private readonly IMapper _mapper;

        public GasSizesListQueryHandler(IMapper mapper, IAsyncRepository<GasSize> gasSizeRepository)
        {
            _mapper = mapper;
            _gasSizeRepository = gasSizeRepository;
        }
        public async Task<List<GasSizeListVm>> Handle(GasSizesListQuery request, CancellationToken cancellationToken)
        {
            var allGasSizes = (await _gasSizeRepository.ListAllAsync()).OrderBy(x => x.SizeInKg);
            return _mapper.Map<List<GasSizeListVm>>(allGasSizes);
        }
    }
}
