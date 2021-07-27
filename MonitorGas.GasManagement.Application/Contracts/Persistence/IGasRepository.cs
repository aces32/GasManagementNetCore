using MonitorGas.GasManagement.Application.Contracts.Persistence;
using MonitorGas.GasManagement.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.Application.Persistence
{
    public interface IGasRepository : IAsyncRepository<Gas>
    {
    }
}
