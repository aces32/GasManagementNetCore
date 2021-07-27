using AutoMapper;
using MonitorGas.GasManagement.App.Services;
using MonitorGas.GasManagement.App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.App.Profiles
{
    public class Mappings : Profile
    {
        public Mappings()
        {
            CreateMap<GasListVm, GasListViewModel>().ReverseMap();
            CreateMap<GasDetailsVm, GasDetailsViewModel>().ReverseMap();

            CreateMap<GasDetailsViewModel, CreateGasCommand>().ReverseMap();
            CreateMap<GasDetailsViewModel, UpdateGasCommand>().ReverseMap();

            CreateMap<GasSizesWithGasesDto, GasesNestedViewModel>().ReverseMap();

            CreateMap<GasSizeDto, GasSizesViewModel>().ReverseMap();
            CreateMap<GasSizeListVm, GasSizesViewModel>().ReverseMap();
            CreateMap<GasSizesListsWithGasesVm, GasSizesWithGasModel>().ReverseMap();
            CreateMap<CreateGasSizeCommand, GasSizesWithGasModel>().ReverseMap();
            CreateMap<CreateGasSizeCommand, GasSizesViewModel>().ReverseMap();
            CreateMap<CreateGasSizeDto, GasSizeDto>().ReverseMap();

            CreateMap<PagedOrdersForMonthVm, PagedOrderForMonthViewModel>().ReverseMap();
            CreateMap<OrdersForMonthDto, OrdersForMonthListViewModel>().ReverseMap();
        }
    }
}
