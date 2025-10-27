using Carrot.Web.Models;

namespace Carrot.Web.Service.IService
{
    public interface IProductService
    {
        Task<ResponseDto> GetProductAsync(string couponCode);
        Task<ResponseDto> GetAllProductsAsync();
        Task<ResponseDto> GetProductByIdAsync(int id);
        Task<ResponseDto> CreateProductsAsync(ProductDto productDto);
        Task<ResponseDto> UpdateProductsAsync(ProductDto productDto);
        Task<ResponseDto> DeleteProductAsync(int id);

    }
}
