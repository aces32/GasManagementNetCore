using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.Application.Features.Gases.Queries.GetGasList
{
    public class GasListVm
    {
        public Guid GasID { get; set; }
        public string GasVendorName { get; set; }
        public DateTime Date { get; set; }
        public string ImageUrl { get; set; }
    }
}
