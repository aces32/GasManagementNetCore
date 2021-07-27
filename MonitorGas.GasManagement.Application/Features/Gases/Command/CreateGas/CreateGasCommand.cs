using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.Application.Features.Gases.Command.CreateGas
{
    public class CreateGasCommand : IRequest<Guid>
    {
        public string GasVendorName { get; set; }
        public int Price { get; set; }
        public string Color { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Guid GasSizeID { get; set; }

        public override string ToString()
        {
            return $"Gas Vendor name: {GasVendorName}; Price: {Price}; color: {Color}; On: {Date.ToShortDateString()}; Description: {Description}";
        }
    }
}
