using AutoMapper;
using MicroServicesApp.Services.CouponAPI.Models;
using MicroServicesApp.Services.CouponAPI.Models.Dtos;

namespace MicroServicesApp.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }
    }
}
