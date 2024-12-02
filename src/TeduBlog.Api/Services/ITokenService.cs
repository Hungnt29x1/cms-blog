using System.Security.Claims;

namespace TeduBlog.Api.Services
{
    public interface ITokenService
    {
        string GenerateAccessToken(IEnumerable<Claim> claims);
        string GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);//Get thông tin cá nhân từ ExpiredToken
    }
}
