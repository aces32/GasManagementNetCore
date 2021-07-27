using MonitorGas.GasManagement.Application.Responses;

namespace MonitorGas.GasManagement.Application.Features.GasSizes.Command.CreateGasSizes
{
    public class CreateGasSizeCommandResponse : BaseResponse
    {
        public CreateGasSizeCommandResponse() : base()
        {

        }
        public CreateGasSizeDto GasSize { get; set; }
    }

}