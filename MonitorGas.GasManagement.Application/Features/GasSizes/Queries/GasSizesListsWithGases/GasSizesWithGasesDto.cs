using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.Application.Features.GasSizes.Queries.GasSizesListsWithGases
{
    public class GasSizesWithGasesDto
    {
        public Guid GasID { get; set; }
        public string GasVendorName { get; set; }
        public int Price { get; set; }
        public string Color { get; set; }
        public DateTime Date { get; set; }
        public Guid GasSizeID { get; set; }
    }
}
