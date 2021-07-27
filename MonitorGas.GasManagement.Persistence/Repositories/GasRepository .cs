using MonitorGas.GasManagement.Application.Persistence;
using MonitorGas.GasManagement.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.Persistence.Repositories
{
    public class GasRepository : BaseRepository<Gas>, IGasRepository
    {
        public GasRepository(MonitorGasDbContext dbContext) : base(dbContext)
        {

        }
    }
}
