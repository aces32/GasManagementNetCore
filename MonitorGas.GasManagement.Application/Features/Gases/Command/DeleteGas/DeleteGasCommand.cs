using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.Application.Features.Gases.Command.DeleteGas
{
    public class DeleteGasCommand : IRequest
    {
        public Guid GasID { get; set; }
    }
}
