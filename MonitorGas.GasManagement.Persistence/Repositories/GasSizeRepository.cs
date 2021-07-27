using Microsoft.EntityFrameworkCore;
using MonitorGas.GasManagement.Application.Contracts.Persistence;
using MonitorGas.GasManagement.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.Persistence.Repositories
{
    public class GasSizeRepository :  BaseRepository<GasSize>, IGasSizeRepository
    {
        public GasSizeRepository(MonitorGasDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<GasSize>> GetGasSizesWithGas(bool includeHistory)
        {
            var allGasSize = await _dbContext.GasSizes.Include(x => x.Gases).ToListAsync();
            if (!includeHistory)
            {
                allGasSize.ForEach(p => p.Gases.ToList().RemoveAll(c => c.Date < DateTime.Today));
            }
            return allGasSize;
        }
    }
}
