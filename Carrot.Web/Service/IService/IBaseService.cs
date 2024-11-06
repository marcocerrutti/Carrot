using Carrot.Web.Models;

namespace Carrot.Web.Service.IService
{
    public interface IBaseService
    {
        Task<ResponseDto?>SendAsync(RequestDto requestDto);
    }
}
