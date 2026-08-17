using Carrot.Services.ShoppingCartAPI.Models.Dto;

namespace Carrot.Services.ShoppingCartAPI.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDto> GetCupon(string CouponCode);
    }
}
