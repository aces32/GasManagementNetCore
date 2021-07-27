using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.Application.Features.GasSizes.Queries.GasSizesListsWithGases
{
    public class GasSizesListsWithGasesVm
    {
        public Guid GasSizeID { get; set; }
        public double SizeInKg { get; set; }
        public ICollection<GasSizesWithGasesDto> Gases { get; set; }
    }
}
