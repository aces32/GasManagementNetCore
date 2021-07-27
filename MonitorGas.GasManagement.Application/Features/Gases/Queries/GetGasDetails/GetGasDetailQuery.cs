using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.Application.Features.Gases.Queries.GetGasDetails
{
    public class GetGasDetailQuery : IRequest<GasDetailsVm>
    {
        public Guid Id { get; set; }
    }
}
