using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.App.ViewModels
{
    public class PagedOrderForMonthViewModel
    {
        public int Count { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
        public ICollection<OrdersForMonthListViewModel> OrdersForMonth { get; set; }
    }
}
