using AutoMapper;
using MonitorGas.GasManagement.Application.Contracts.Persistence;
using MonitorGas.GasManagement.Application.Features.GasSizes.Queries.GasSizesList;
using MonitorGas.GasManagement.Application.Profiles;
using MonitorGas.GasManagement.Application.UnitTests.Mocks;
using MonitorGas.GasManagement.Domain.Entites;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace MonitorGas.GasManagement.Application.UnitTests.GasSizes.Queries
{
    public class GetGasSizesListQueryHandlerTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IAsyncRepository<GasSize>> _mockGasSizeRepository;

        public GetGasSizesListQueryHandlerTests()
        {
            _mockGasSizeRepository = GasSizeRepositoryMock.GetGasSizeRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task GetGasSizeListTest()
        {
            var handler = new GasSizesListQueryHandler(_mapper, _mockGasSizeRepository.Object);

            var result = await handler.Handle(new GasSizesListQuery(), CancellationToken.None);

            result.ShouldBeOfType<List<GasSizeListVm>>();

            result.Count.ShouldBe(4);
        }
    }
}
