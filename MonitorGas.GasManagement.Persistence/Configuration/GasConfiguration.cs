using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MonitorGas.GasManagement.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.Persistence.Configuration
{
    public class GasConfiguration : IEntityTypeConfiguration<Gas>
    {
        public void Configure(EntityTypeBuilder<Gas> builder)
        {
            builder.Property(e => e.GasVendorName)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
