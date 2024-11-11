using UserProvider.Business.Interfaces;
using UserProvider.Business.Models;

namespace UserProvider.Business.Services;

public class UserValidator : IUserValidator
{
    public UserValidatorResult Validate(UserRequest request)
    {
        return new UserValidatorResult { Success = true };
    }
}
