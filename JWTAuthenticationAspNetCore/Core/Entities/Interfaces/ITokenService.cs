using Entities;

namespace JWTAuthenticationAspNetCore.Core.Entities.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);

    }
}