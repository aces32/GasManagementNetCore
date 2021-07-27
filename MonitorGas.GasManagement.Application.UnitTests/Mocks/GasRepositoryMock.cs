using MonitorGas.GasManagement.Application.Contracts.Persistence;
using MonitorGas.GasManagement.Domain.Entites;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.Application.UnitTests.Mocks
{
    public class GasRepositoryMock
    {
        public static Mock<IAsyncRepository<Gas>> GetGasRepository()
        {
            var tenKgGuid = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76A7C5DDE}");
            var twentyKgGuid = Guid.Parse("{6313179F-7837-473A-A4D5-A5571B43E6A6}");
            var thirtyKgGuid = Guid.Parse("{BF3F3002-7E53-441E-8B76-F6280BE284AA}");

            var gases = new List<Gas>
            {
                new Gas
                {
                    GasID = Guid.Parse("{EE272F8B-6096-4CB6-8625-BB4BB2D89E8B}"),
                    GasVendorName = "ABC Gas Limited",
                    Price = 65,
                    Color = "Red",
                    Date = DateTime.Now.AddMonths(6),
                    Description = "Red gas added to the company by Abc Ga limited.",
                    ImageUrl = "https://theoilbloc.com/wp-content/uploads/2020/06/gas-cylinder.jpg",
                    GasSizeID = twentyKgGuid
                },
                new Gas
                {
                    GasID = Guid.Parse("{7ea5e087-06e7-4bfc-ab17-bb182a42ce3d}"),
                    GasVendorName = "ABC Gas Limited",
                    Price = 95,
                    Color = "Yellow",
                    Date = DateTime.Now.AddMonths(4),
                    Description = "Yellow gas added to the company by Abc Gas limited.",
                    ImageUrl = "https://theoilbloc.com/wp-content/uploads/2020/06/gas-cylinder.jpg",
                    GasSizeID = twentyKgGuid
                },
                new Gas
                {
                    GasID = Guid.Parse("{51d03858-68eb-4887-94a0-2ed111ef954b}"),
                    GasVendorName = "Red Coporate Gas Limited",
                    Price = 25,
                    Color = "Blue",
                    Date = DateTime.Now.AddMonths(6),
                    Description = "Red gas added to the company by Red Coporate Gas limited.",
                    ImageUrl = "https://theoilbloc.com/wp-content/uploads/2020/06/gas-cylinder.jpg",
                    GasSizeID = tenKgGuid
                },
                new Gas
                {
                    GasID = Guid.Parse("{7bc4b468-2c09-44b0-9ddb-32d09aec5b08}"),
                    GasVendorName = "Smart Gas Limited",
                    Price = 175,
                    Color = "Green",
                    Date = DateTime.Now.AddMonths(6),
                    Description = "Green added to the company by Smart Gas Limited.",
                    ImageUrl = "https://theoilbloc.com/wp-content/uploads/2020/06/gas-cylinder.jpg",
                    GasSizeID = thirtyKgGuid
                }
            };


            var mockGasSizeRepository = new Mock<IAsyncRepository<Gas>>();
            mockGasSizeRepository.Setup(repo => repo.ListAllAsync()).ReturnsAsync(gases);

            mockGasSizeRepository.Setup(repo => repo.AddAsync(It.IsAny<Gas>())).ReturnsAsync(
                (Gas gas) =>
                {
                    gases.Add(gas);
                    return gas;
                });

            return mockGasSizeRepository;
        }


    }


}
