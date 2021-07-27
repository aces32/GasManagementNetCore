using AutoMapper;
using MonitorGas.GasManagement.Application.Contracts.Persistence;
using MonitorGas.GasManagement.Application.Features.GasSizes.Command.CreateGasSizes;
using MonitorGas.GasManagement.Application.Profiles;
using MonitorGas.GasManagement.Application.UnitTests.Mocks;
using MonitorGas.GasManagement.Domain.Entites;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace MonitorGas.GasManagement.Application.UnitTests.GasSizes.Commands
{
    public class CreateGasSizesTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<IAsyncRepository<GasSize>> _mockGasSizeRepository;

        public CreateGasSizesTest()
        {
            _mockGasSizeRepository = GasSizeRepositoryMock.GetGasSizeRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task Handle_ValidGasSize_AddedToGasSizesRepo()
        {
            var handler = new CreateGasSizeCommandHandler(_mapper, _mockGasSizeRepository.Object);

            await handler.Handle(new CreateGasSizeCommand() { SizeInKg = 60 }, CancellationToken.None);

            var allGasSizes = await _mockGasSizeRepository.Object.ListAllAsync();
            allGasSizes.Count.ShouldBe(5);
        }
    }
}
