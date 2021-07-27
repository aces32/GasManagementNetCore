using MonitorGas.GasManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.Domain.Entites
{
    public class GasSize : AuditableEntity
    {
        public Guid GasSizeID { get; set; }
        public double SizeInKg { get; set; }
        public ICollection<Gas> Gases { get; set; }
    }
}
