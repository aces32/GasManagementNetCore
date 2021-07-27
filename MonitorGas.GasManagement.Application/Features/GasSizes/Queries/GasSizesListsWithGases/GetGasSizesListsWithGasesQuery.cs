using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.Application.Features.GasSizes.Queries.GasSizesListsWithGases
{
    public class GetGasSizesListsWithGasesQuery : IRequest<List<GasSizesListsWithGasesVm>>
    {
        public bool IncludeHistory { get; set; }
    }
}
