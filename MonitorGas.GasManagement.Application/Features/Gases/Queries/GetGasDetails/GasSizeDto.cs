using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.Application.Features.Gases.Queries.GetGasDetails
{
    public class GasSizeDto
    {
        public Guid GasSizeID { get; set; }
        public int SizeInKg { get; set; }
    }
}
