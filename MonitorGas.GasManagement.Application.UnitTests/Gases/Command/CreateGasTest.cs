using AutoMapper;
using Microsoft.Extensions.Logging;
using MonitorGas.GasManagement.Application.Contracts.Infrastructure;
using MonitorGas.GasManagement.Application.Contracts.Persistence;
using MonitorGas.GasManagement.Application.Features.Gases.Command.CreateGas;
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

namespace MonitorGas.GasManagement.Application.UnitTests.Gases.Command
{
    public class CreateGasTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<IAsyncRepository<Gas>> _mockGasRepository;
        private readonly Mock<ILogger<CreateGasCommandHandler>> logger;
        private readonly Mock<IEmailService> mail;


        public CreateGasTest()
        {
            _mockGasRepository = GasRepositoryMock.GetGasRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            logger = new Mock<ILogger<CreateGasCommandHandler>>();
            mail = new Mock<IEmailService>();
            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task Handle_ValidGas_AddedToGasRepo()
        {
            var handler = new CreateGasCommandHandler(_mapper, _mockGasRepository.Object, mail.Object, logger.Object);

            await handler.Handle(new CreateGasCommand()
            {
                GasVendorName = "ABC Gas Limited",
                Price = 65,
                Color = "Red",
                Date = DateTime.Now.AddMonths(6),
                Description = "Red gas added to the company by Abc Ga limited.",
                ImageUrl = "https://theoilbloc.com/wp-content/uploads/2020/06/gas-cylinder.jpg",
                GasSizeID = Guid.NewGuid()
            }, CancellationToken.None);

            var allGasSizes = await _mockGasRepository.Object.ListAllAsync();
            allGasSizes.Count.ShouldBe(5);
        }
    }
}
