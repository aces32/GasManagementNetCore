using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.Application.Features.Gases.Queries.GetGasList
{
    public class GetGasListQuery : IRequest<List<GasListVm>>
    {
    }
}
