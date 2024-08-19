using ASProject.Domain.Entity;
using ASProject.Domain.Result;

namespace ASProject.Domain.Interfaces.Validations;

public interface IReportValidator : IBaseValidator<Report>
{
    /// <summary>
    /// Проверяется наличие отчёта, если отчёт с переданным название уже есть, то создать точно такой же нельзя
    /// Проверяется пользователю, если с UserId пользователь не найден, то такого пользователя нет
    /// </summary>
    /// <param name="report"></param>
    /// <param name="user"></param>
    /// <returns></returns>
    BaseResult CreateValidator(Report report, User user);
}