using Microsoft.AspNetCore.Components;
using MonitorGas.GasManagement.App.Contracts;
using MonitorGas.GasManagement.App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.App.Pages
{
    public partial class GasSizOverView
    {
        [Inject]
        public IGasSizeDataService GasSizeDataService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public ICollection<GasSizesWithGasModel> GasSizes { get; set; }

        protected async override Task OnInitializedAsync()
        {
            GasSizes = await GasSizeDataService.GetAllGasSizesWithGases(false);
        }

        protected async void OnIncludeHistoryChanged(ChangeEventArgs args)
        {
            if ((bool)args.Value)
            {
                GasSizes = await GasSizeDataService.GetAllGasSizesWithGases(true);
            }
            else
            {
                GasSizes = await GasSizeDataService.GetAllGasSizesWithGases(false);
            }
        }
    }
}
