using AutoMapper;
using MonitorGas.GasManagement.Application.Contracts.Persistence;
using MonitorGas.GasManagement.Application.Features.Gases.Queries.GetGasList;
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

namespace MonitorGas.GasManagement.Application.UnitTests.Gases.Queries
{
    public class GetGasListQueryHandlerTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<IAsyncRepository<Gas>> _mockGasRepository;

        public GetGasListQueryHandlerTest()
        {
            _mockGasRepository = GasRepositoryMock.GetGasRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task GetGasListTest()
        {
            var handler = new GetGasListQueryHandler(_mapper, _mockGasRepository.Object);

            var result = await handler.Handle(new GetGasListQuery(), CancellationToken.None);

            result.ShouldBeOfType<List<GasListVm>>();

            result.Count.ShouldBe(4);
        }
    }
}
