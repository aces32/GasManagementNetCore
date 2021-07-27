using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.App.ViewModels
{
    public class OrdersForMonthListViewModel
    {
        public Guid Id { get; set; }
        public int OrderTotal { get; set; }
        public DateTime OrderPlaced { get; set; }
    }
}
