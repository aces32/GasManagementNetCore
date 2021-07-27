using Microsoft.AspNetCore.Components;
using MonitorGas.GasManagement.App.Contracts;
using MonitorGas.GasManagement.App.Services;
using MonitorGas.GasManagement.App.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.App.Pages
{
    public partial class GazDetails
    {
        [Inject]
        public IGasDataService GasDataService { get; set; }

        [Inject]
        public IGasSizeDataService GasSizeDataService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public GasDetailsViewModel GasDetailViewModel { get; set; }
            = new GasDetailsViewModel() { Date = DateTime.Now.AddDays(1) };

        public ObservableCollection<GasSizesViewModel> GasSizes { get; set; }
            = new ObservableCollection<GasSizesViewModel>();

        public string Message { get; set; }
        public string SelectedGasSizesId { get; set; }

        [Parameter]
        public string GasId { get; set; }
        private Guid SelectedGasId = Guid.Empty;

        protected override async Task OnInitializedAsync()
        {
            if (Guid.TryParse(GasId, out SelectedGasId))
            {
                GasDetailViewModel = await GasDataService.GetGasById(SelectedGasId);
                SelectedGasSizesId = GasDetailViewModel.GasSizeID.ToString();
            }

            var list = await GasSizeDataService.GetAllGasSizes();
            GasSizes = new ObservableCollection<GasSizesViewModel>(list);
            SelectedGasSizesId = GasSizes.FirstOrDefault().GasSizeID.ToString();
        }

        protected async Task HandleValidSubmit()
        {
            GasDetailViewModel.GasSizeID = Guid.Parse(SelectedGasSizesId);
            ApiResponse<Guid> response;

            if (SelectedGasId == Guid.Empty)
            {
                response = await GasDataService.CreateGas(GasDetailViewModel);
            }
            else
            {
                response = await GasDataService.UpdateGas(GasDetailViewModel);
            }
            HandleResponse(response);

        }

        protected async Task DeleteGas()
        {
            var response = await GasDataService.DeleteGas(SelectedGasId);
            HandleResponse(response);
        }

        protected void NavigateToOverview()
        {
            NavigationManager.NavigateTo("/GasOverView");
        }

        private void HandleResponse(ApiResponse<Guid> response)
        {
            if (response.Success)
            {
                NavigationManager.NavigateTo("/GasOverView");
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

