using System.Linq;
using AutoMapper;
using CarDeal.API.Services.DTO;
using CarDeal.API.Services.EF.Entities.Cars;

namespace CarDeal.API.Services.AutoMapper
{
    public static class AutoMapperConfig
    {
        public static IMapper Create()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BodyType, BodyTypeDto>().ReverseMap();
                cfg.CreateMap<FuelType, FuelTypeDto>().ReverseMap();
                cfg.CreateMap<VehicleBrand, VehicleBrandDto>().ReverseMap();
                
                cfg.CreateMap<CarAd, CarAdDto>()
                    .ForMember(dest => dest.BodyType,
                        opts => opts.MapFrom(src => src.BodyType))
                    .ForMember(dest => dest.FuelType,
                        opts => opts.MapFrom(src => src.FuelType))
                    .ForMember(dest => dest.VehicleBrand,
                        opts => opts.MapFrom(src => src.VehicleBrand));
            });

            return configuration.CreateMapper();
        }
    }
}