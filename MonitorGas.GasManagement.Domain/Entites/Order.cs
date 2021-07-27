using MonitorGas.GasManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.Domain.Entites
{
    public class Order : AuditableEntity
    {
        public Guid Id { get; set; }
        public Guid UserID { get; set; }
        public int OrderTotal { get; set; }
        public DateTime OrderPlaced { get; set; }
        public bool OrderPaid { get; set; }
    }
}
