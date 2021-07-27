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
    public class GasSizeRepositoryMock
    {
        public static Mock<IAsyncRepository<GasSize>> GetGasSizeRepository()
        {
            var tenKgGuid = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76A7C5DDE}");
            var twentyKgGuid = Guid.Parse("{6313179F-7837-473A-A4D5-A5571B43E6A6}");
            var thirtyKgGuid = Guid.Parse("{BF3F3002-7E53-441E-8B76-F6280BE284AA}");

            var gasSizes = new List<GasSize>
            {
                new GasSize
                {
                    GasSizeID = tenKgGuid,
                    SizeInKg = 10
                },
                new GasSize
                {
                    GasSizeID = twentyKgGuid,
                    SizeInKg = 20
                },
                new GasSize
                {
                    GasSizeID = twentyKgGuid,
                    SizeInKg = 20
                },
                new GasSize
                {
                    GasSizeID = thirtyKgGuid,
                    SizeInKg = 30
                }
            };



            var mockGasSizeRepository = new Mock<IAsyncRepository<GasSize>>();
            mockGasSizeRepository.Setup(repo => repo.ListAllAsync()).ReturnsAsync(gasSizes);

            mockGasSizeRepository.Setup(repo => repo.AddAsync(It.IsAny<GasSize>())).ReturnsAsync(
                (GasSize gasSize) =>
                {
                    gasSizes.Add(gasSize);
                    return gasSize;
                });

            return mockGasSizeRepository;
        }
    }
}
