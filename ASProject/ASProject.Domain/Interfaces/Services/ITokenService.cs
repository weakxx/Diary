using System.Security.Claims;
using ASProject.Domain.Dto;
using ASProject.Domain.Result;

namespace ASProject.Domain.Interfaces.Services;

public interface ITokenService
{
    string GenerateAccessToken(IEnumerable<Claim> claims);

    string GenerateRefreshToken();

    ClaimsPrincipal GetPrincipalFromExpiredToken(string accessToken);
    
    Task<BaseResult<TokenDto>> RefreshToken(TokenDto dto);
}