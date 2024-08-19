using ASProject.Domain.Result;

namespace ASProject.Domain.Interfaces.Validations;

public interface IBaseValidator<in T> where T : class
{
    BaseResult ValidateOnNull(T model);
}