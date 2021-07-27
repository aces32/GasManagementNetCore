using AutoMapper;
using MediatR;
using MonitorGas.GasManagement.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.Application.Features.GasSizes.Queries.GasSizesListsWithGases
{
    public class GetGasSizesListsWithGasesQueryHandler : IRequestHandler<GetGasSizesListsWithGasesQuery, List<GasSizesListsWithGasesVm>>
    {
        private readonly IMapper _mapper;
        private readonly IGasSizeRepository _gasSizeRepository;

        public GetGasSizesListsWithGasesQueryHandler(IMapper mapper, IGasSizeRepository gasSizeRepository)
        {
            _mapper = mapper;
            _gasSizeRepository = gasSizeRepository;
        }
        public async Task<List<GasSizesListsWithGasesVm>> Handle(GetGasSizesListsWithGasesQuery request, CancellationToken cancellationToken)
        {
            var list = await _gasSizeRepository.GetGasSizesWithGas(request.IncludeHistory);
            return _mapper.Map<List<GasSizesListsWithGasesVm>>(list);
        }
    }
}
