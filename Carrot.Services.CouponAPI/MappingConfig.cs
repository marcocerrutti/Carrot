using AutoMapper;
using Carrot.Services.CouponAPI.Models;
using Carrot.Services.CouponAPI.Models.Dto;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Carrot.Services.CouponAPI
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
