using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MonitorGas.GasManagement.App.Contracts;
using MonitorGas.GasManagement.App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.App.Pages
{
    public partial class GasOverView
    {
        [Inject]
        public IGasDataService GasDataService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public ICollection<GasListViewModel> Gases { get; set; }

        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Gases = await GasDataService.GetAllGas();
        }

        protected void AddNewGas()
        {
            NavigationManager.NavigateTo("/gasdetails");
        }
    }
}
