using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.Application.Features.GasSizes.Command.CreateGasSizes
{
    public class CreateGasSizeCommand : IRequest<CreateGasSizeCommandResponse>
    {
        public int SizeInKg { get; set; }
    }
}
