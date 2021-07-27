using MonitorGas.GasManagement.App.Services;
using MonitorGas.GasManagement.App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.App.Contracts
{
    public interface IGasDataService
    {
        Task<List<GasListViewModel>> GetAllGas();
        Task<GasDetailsViewModel> GetGasById(Guid id);
        Task<ApiResponse<Guid>> CreateGas(GasDetailsViewModel gasDetailViewModel);
        Task<ApiResponse<Guid>> UpdateGas(GasDetailsViewModel gasDetailViewModel);
        Task<ApiResponse<Guid>> DeleteGas(Guid id);
    }
}
