using AutoMapper;
using Blazored.LocalStorage;
using Blazored.SessionStorage;
using MonitorGas.GasManagement.App.Contracts;
using MonitorGas.GasManagement.App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.App.Services
{
    public class GasDataService : BaseDataService, IGasDataService
    {
        private readonly IMapper _mapper;
        public GasDataService(IClient client, IMapper mapper, ILocalStorageService localStorage, ISessionStorageService sessionstorage) : base(client, localStorage, sessionstorage)
        {
            _mapper = mapper;
        }
        public async Task<ApiResponse<Guid>> CreateGas(GasDetailsViewModel gasDetailViewModel)
        {
            try
            {
                await AddBearerToken();
                CreateGasCommand createGasCommand = _mapper.Map<CreateGasCommand>(gasDetailViewModel);
                var newId = await _client.AddGasAsync(createGasCommand);
                return new ApiResponse<Guid>() { Data = newId, Success = true };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<Guid>(ex);
            }
        }

        public async Task<ApiResponse<Guid>> DeleteGas(Guid id)
        {
            try
            {
                await AddBearerToken();
                await _client.DeleteGasAsync(id);
                return new ApiResponse<Guid>() { Success = true };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<Guid>(ex);
            }
        }

        public async Task<List<GasListViewModel>> GetAllGas()
        {
            await AddBearerToken();
            var allGas = await _client.GetAllGasAsync();
            var mappedGas = _mapper.Map<ICollection<GasListViewModel>>(allGas);
            return mappedGas.ToList();
        }

        public async Task<GasDetailsViewModel> GetGasById(Guid id)
        {
            await AddBearerToken();
            var selectedGas = await _client.GetGasByIdAsync(id);
            var mappedGas = _mapper.Map<GasDetailsViewModel>(selectedGas);
            return mappedGas;
        }

        public async Task<ApiResponse<Guid>> UpdateGas(GasDetailsViewModel gasDetailViewModel)
        {
            try
            {
                await AddBearerToken();
                UpdateGasCommand updateGasCommand = _mapper.Map<UpdateGasCommand>(gasDetailViewModel);
                await _client.UpdateGasAsync(updateGasCommand);
                return new ApiResponse<Guid>() { Success = true };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<Guid>(ex);
            }
        }
    }
}
