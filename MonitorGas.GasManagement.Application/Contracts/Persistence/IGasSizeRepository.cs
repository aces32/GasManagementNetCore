using MonitorGas.GasManagement.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.Application.Contracts.Persistence
{
    public interface IGasSizeRepository : IAsyncRepository<GasSize>
    {
        Task<List<GasSize>> GetGasSizesWithGas(bool includeHistory);
    }
}
