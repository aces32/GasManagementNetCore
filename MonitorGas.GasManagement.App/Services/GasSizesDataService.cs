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
    public class GasSizesDataService : BaseDataService, IGasSizeDataService
    {
        private readonly IMapper _mapper;

        public GasSizesDataService(IClient client, IMapper mapper, ILocalStorageService localStorage, ISessionStorageService sessionstorage) : base(client, localStorage, sessionstorage)
        {
            _mapper = mapper;
        }
        public async Task<ApiResponse<GasSizeDto>> CreateGasSize(GasSizesViewModel gasSizeViewModel)
        {
            try
            {
                await AddBearerToken();
                ApiResponse<GasSizeDto> apiResponse = new ApiResponse<GasSizeDto>();
                CreateGasSizeCommand createGasSizeCommand = _mapper.Map<CreateGasSizeCommand>(gasSizeViewModel);
                var createGasSizeCommandResponse = await _client.AddGasSizeAsync(createGasSizeCommand);
                if (createGasSizeCommandResponse.Success)
                {
                    apiResponse.Data = _mapper.Map<GasSizeDto>(createGasSizeCommandResponse.GasSize);
                    apiResponse.Success = true;
                }
                else
                {
                    apiResponse.Data = null;
                    foreach (var error in createGasSizeCommandResponse.ValidationErrors)
                    {
                        apiResponse.ValidationErrors += error + Environment.NewLine;
                    }
                }
                return apiResponse;
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<GasSizeDto>(ex);
            }
        }

        public async Task<List<GasSizesViewModel>> GetAllGasSizes()
        {
            await AddBearerToken();
            var allGases = await _client.GetAllGasSizesAsync();
            var mappedGases = _mapper.Map<ICollection<GasSizesViewModel>>(allGases);
            return mappedGases.ToList();
        }

        public async Task<List<GasSizesWithGasModel>> GetAllGasSizesWithGases(bool includeHistory)
        {
            await AddBearerToken();
            var allGases = await _client.GetAllGasSizesWithGasesAsync(includeHistory);
            var mappedGases = _mapper.Map<ICollection<GasSizesWithGasModel>>(allGases);
            return mappedGases.ToList();
        }

    }
}
