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
    public partial class OrderDataService : BaseDataService, IOrderDataService
    {
        private readonly IMapper _mapper;

        public OrderDataService(IClient client, IMapper mapper, ILocalStorageService localStorage, ISessionStorageService sessionstorage) : base(client, localStorage, sessionstorage)
        {
            _mapper = mapper;
        }

        public async Task<PagedOrderForMonthViewModel> GetPagedOrderForMonth(DateTime date, int page, int size)
        {
            await AddBearerToken();
            var orders = await _client.GetPagedOrdersForMonthAsync(date, page, size);
            var mappedOrders = _mapper.Map<PagedOrderForMonthViewModel>(orders);
            return mappedOrders;
        }
    }
}
