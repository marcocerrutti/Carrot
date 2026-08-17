using Carrot.Services.ShoppingCartAPI.Models.Dto;

namespace Carrot.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
