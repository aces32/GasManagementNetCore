using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.Application.Features.Orders.Queries.GetOrderForTheMonth
{
    public class OrdersForMonthDto
    {
        public Guid Id { get; set; }
        public int OrderTotal { get; set; }
        public DateTime OrderPlaced { get; set; }
    }
}
