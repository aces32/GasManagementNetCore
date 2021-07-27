using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.Application.Features.GasSizes.Queries.GasSizesList
{
    public class GasSizeListVm
    {
        public Guid GasSizeID { get; set; }
        public int SizeInKg { get; set; }
    }
}
