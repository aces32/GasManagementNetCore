using Microsoft.AspNetCore.Components;
using MonitorGas.GasManagement.App.Contracts;
using MonitorGas.GasManagement.App.Services;
using MonitorGas.GasManagement.App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.App.Pages
{
    public partial class AddGasSize
    {
        [Inject]
        public IGasSizeDataService GasSizeDataService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public GasSizesViewModel GasSizesViewModel { get; set; }
        public string Message { get; set; }

        protected override void OnInitialized()
        {
            GasSizesViewModel = new GasSizesViewModel();
        }

        protected async Task HandleValidSubmit()
        {
            var response = await GasSizeDataService.CreateGasSize(GasSizesViewModel);
            HandleResponse(response);
        }

        private void HandleResponse(ApiResponse<GasSizeDto> response)
        {
            if (response.Success)
            {
                Message = "Gas Size added";
            }
            else
            {
                Message = response.Message;
                if (!string.IsNullOrEmpty(response.ValidationErrors))
                    Message += response.ValidationErrors;
            }
        }
    }
}
