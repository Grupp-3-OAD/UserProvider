using UserProvider.Business.Models;

namespace UserProvider.Business.Interfaces
{
    public interface IUserValidator
    {
        UserValidatorResult Validate(UserRequest request);

    }
}
