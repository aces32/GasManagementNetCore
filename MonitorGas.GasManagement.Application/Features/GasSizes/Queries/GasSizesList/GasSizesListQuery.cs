using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.Application.Features.GasSizes.Queries.GasSizesList
{
    public class GasSizesListQuery : IRequest<List<GasSizeListVm>>
    {
    }
}
