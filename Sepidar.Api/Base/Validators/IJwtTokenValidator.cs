using System.Security.Claims;

namespace Sepidar.api.Base.Validators
{
    public interface IJwtTokenValidator
    {
        ClaimsPrincipal GetPrincipalFromToken(string token, string signingKey);
    }
}
