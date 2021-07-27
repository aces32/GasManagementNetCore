using Microsoft.EntityFrameworkCore;
using MonitorGas.GasManagement.Domain.Common;
using MonitorGas.GasManagement.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.Persistence
{
    public class MonitorGasDbContext : DbContext
    {
        public MonitorGasDbContext(DbContextOptions<MonitorGasDbContext> options)
        : base(options)
        {
        }

        public DbSet<Gas> Gases { get; set; }
        public DbSet<GasSize> GasSizes { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MonitorGasDbContext).Assembly);

            var tenKgGuid = Guid.Parse("9110ec52-c457-4924-a7ee-03e497fa865d");
            var twentyKgGuid = Guid.Parse("089be77d-e198-4832-9eb5-4a041b155506");
            var thirtyKgGuid = Guid.Parse("1bf57a70-e896-4273-874d-15a38291d73b");
            var fourtyKgGuid = Guid.Parse("3fe536ae-ada3-4097-b255-aa27f8d65c87");

            modelBuilder.Entity<GasSize>().HasData(new GasSize
            {
                GasSizeID = tenKgGuid,
                SizeInKg = 10
            });

            modelBuilder.Entity<GasSize>().HasData(new GasSize
            {
                GasSizeID = twentyKgGuid,
                SizeInKg = 20
            });

            modelBuilder.Entity<GasSize>().HasData(new GasSize
            {
                GasSizeID = thirtyKgGuid,
                SizeInKg = 30
            });

            modelBuilder.Entity<GasSize>().HasData(new GasSize
            {
                GasSizeID = fourtyKgGuid,
                SizeInKg = 40
            });

            modelBuilder.Entity<Gas>().HasData(new Gas
            {
                GasID = Guid.Parse("{EE272F8B-6096-4CB6-8625-BB4BB2D89E8B}"),
                GasVendorName = "ABC Gas Limited",
                Price = 65,
                Color = "Red",
                Date = DateTime.Now.AddMonths(6),
                Description = "Red gas added to the company by Abc Ga limited.",
                ImageUrl = "https://theoilbloc.com/wp-content/uploads/2020/06/gas-cylinder.jpg",
                GasSizeID = twentyKgGuid
            });
            modelBuilder.Entity<Gas>().HasData(new Gas
            {
                GasID = Guid.Parse("{7ea5e087-06e7-4bfc-ab17-bb182a42ce3d}"),
                GasVendorName = "ABC Gas Limited",
                Price = 95,
                Color = "Yellow",
                Date = DateTime.Now.AddMonths(4),
                Description = "Yellow gas added to the company by Abc Gas limited.",
                ImageUrl = "https://theoilbloc.com/wp-content/uploads/2020/06/gas-cylinder.jpg",
                GasSizeID = twentyKgGuid
            });
            modelBuilder.Entity<Gas>().HasData(new Gas
            {
                GasID = Guid.Parse("{51d03858-68eb-4887-94a0-2ed111ef954b}"),
                GasVendorName = "Red Coporate Gas Limited",
                Price = 25,
                Color = "Blue",
                Date = DateTime.Now.AddMonths(6),
                Description = "Red gas added to the company by Red Coporate Gas limited.",
                ImageUrl = "https://theoilbloc.com/wp-content/uploads/2020/06/gas-cylinder.jpg",
                GasSizeID = tenKgGuid
            });
            modelBuilder.Entity<Gas>().HasData(new Gas
            {
                GasID = Guid.Parse("{7bc4b468-2c09-44b0-9ddb-32d09aec5b08}"),
                GasVendorName = "Smart Gas Limited",
                Price = 175,
                Color = "Green",
                Date = DateTime.Now.AddMonths(6),
                Description = "Green added to the company by Smart Gas Limited.",
                ImageUrl = "https://theoilbloc.com/wp-content/uploads/2020/06/gas-cylinder.jpg",
                GasSizeID = thirtyKgGuid
            });

            modelBuilder.Entity<Order>().HasData(new Order
            {
                Id = Guid.Parse("{7E94BC5B-71A5-4C8C-BC3B-71BB7976237E}"),
                OrderTotal = 400,
                OrderPaid = true,
                OrderPlaced = DateTime.Now,
                UserID = Guid.Parse("{A441EB40-9636-4EE6-BE49-A66C5EC1330B}")
            });

            modelBuilder.Entity<Order>().HasData(new Order
            {
                Id = Guid.Parse("{86D3A045-B42D-4854-8150-D6A374948B6E}"),
                OrderTotal = 135,
                OrderPaid = true,
                OrderPlaced = DateTime.Now,
                UserID = Guid.Parse("{AC3CFAF5-34FD-4E4D-BC04-AD1083DDC340}")
            });

            modelBuilder.Entity<Order>().HasData(new Order
            {
                Id = Guid.Parse("{771CCA4B-066C-4AC7-B3DF-4D12837FE7E0}"),
                OrderTotal = 85,
                OrderPaid = true,
                OrderPlaced = DateTime.Now,
                UserID = Guid.Parse("{D97A15FC-0D32-41C6-9DDF-62F0735C4C1C}")
            });

            modelBuilder.Entity<Order>().HasData(new Order
            {
                Id = Guid.Parse("{3DCB3EA0-80B1-4781-B5C0-4D85C41E55A6}"),
                OrderTotal = 245,
                OrderPaid = true,
                OrderPlaced = DateTime.Now,
                UserID = Guid.Parse("{4AD901BE-F447-46DD-BCF7-DBE401AFA203}")
            });

            modelBuilder.Entity<Order>().HasData(new Order
            {
                Id = Guid.Parse("{E6A2679C-79A3-4EF1-A478-6F4C91B405B6}"),
                OrderTotal = 142,
                OrderPaid = true,
                OrderPlaced = DateTime.Now,
                UserID = Guid.Parse("{7AEB2C01-FE8E-4B84-A5BA-330BDF950F5C}")
            });

            modelBuilder.Entity<Order>().HasData(new Order
            {
                Id = Guid.Parse("{F5A6A3A0-4227-4973-ABB5-A63FBE725923}"),
                OrderTotal = 40,
                OrderPaid = true,
                OrderPlaced = DateTime.Now,
                UserID = Guid.Parse("{F5A6A3A0-4227-4973-ABB5-A63FBE725923}")
            });
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
