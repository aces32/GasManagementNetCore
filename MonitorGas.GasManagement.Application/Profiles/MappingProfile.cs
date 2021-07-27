using AutoMapper;
using MonitorGas.GasManagement.Application.Features.Gases.Command.CreateGas;
using MonitorGas.GasManagement.Application.Features.Gases.Command.UpdateGas;
using MonitorGas.GasManagement.Application.Features.Gases.Queries.GetGasDetails;
using MonitorGas.GasManagement.Application.Features.Gases.Queries.GetGasList;
using MonitorGas.GasManagement.Application.Features.GasSizes.Command.CreateGasSizes;
using MonitorGas.GasManagement.Application.Features.GasSizes.Queries.GasSizesList;
using MonitorGas.GasManagement.Application.Features.GasSizes.Queries.GasSizesListsWithGases;
using MonitorGas.GasManagement.Application.Features.Orders.Queries.GetOrderForTheMonth;
using MonitorGas.GasManagement.Domain.Entites;

namespace MonitorGas.GasManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Gas, GasDetailsVm>().ReverseMap();
            CreateMap<Gas, GasSizeDto>().ReverseMap();
            CreateMap<Gas, GasListVm>().ReverseMap();
            CreateMap<Gas, UpdateGasCommand>().ReverseMap();
            CreateMap<Gas, GasSizesWithGasesDto>().ReverseMap();
            CreateMap<Gas, CreateGasCommand>().ReverseMap();

            CreateMap<GasSize, GasSizeListVm>().ReverseMap();
            CreateMap<GasSize, GasSizesListsWithGasesVm>().ReverseMap();
            CreateMap<GasSize, CreateGasSizeDto>().ReverseMap();
            CreateMap<GasSize, GasSizeDto>().ReverseMap();

            CreateMap<Order, OrdersForMonthDto>();

        }
    }
}
