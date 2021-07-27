using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.Application.Features.Gases.Command.UpdateGas
{
    public class UpdateGasCommand : IRequest
    {
        public Guid GasID { get; set; }
        public string GasVendorName { get; set; }
        public int Price { get; set; }
        public string Color { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Guid GasSizeID { get; set; }
    }
}
