using System;

namespace MonitorGas.GasManagement.Application.Features.GasSizes.Command.CreateGasSizes
{
    public class CreateGasSizeDto
    {
        public Guid GasSizeID { get; set; }
        public int SizeInKg { get; set; }
    }
}