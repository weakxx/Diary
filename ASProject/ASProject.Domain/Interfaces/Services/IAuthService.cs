using ASProject.Domain.Dto;
using ASProject.Domain.Dto.User;
using ASProject.Domain.Result;

namespace ASProject.Domain.Interfaces.Services;

/// <summary>
/// Сервис для авторизации или регистрации
/// </summary>
public interface IAuthService
{
    /// <summary>
    /// Регистрация пользователя
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    Task<BaseResult<UserDto>> Register(RegisterUserDto dto);
    
    /// <summary>
    /// Авторизация пользователя
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    Task<BaseResult<TokenDto>> Login(LoginUserDto dto);
}