using MonitorGas.GasManagement.App.Services;
using MonitorGas.GasManagement.App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.App.Contracts
{
    public interface IGasSizeDataService
    {
        Task<List<GasSizesViewModel>> GetAllGasSizes();
        Task<List<GasSizesWithGasModel>> GetAllGasSizesWithGases(bool includeHistory);
        Task<ApiResponse<GasSizeDto>> CreateGasSize(GasSizesViewModel gasSizeViewModel);
    }
}
