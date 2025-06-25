using Carrot.Services.AuthAPI.Models;

namespace Carrot.Services.AuthAPI.Service.IService
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser);

    }
}
