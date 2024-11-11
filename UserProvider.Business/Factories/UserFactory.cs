using UserProvider.Business.Models;

namespace UserProvider.Business.Factories;

public static class UserFactory
{
    public static UserEntity Create(UserRequest request)
    {
        return new UserEntity
        {
            UserId = Guid.NewGuid().ToString(),
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email,
            Password = request.Password

        };
    }

    public static User Create(UserEntity entity)
    {
        return new User
        {
            UserId= entity.UserId,
            FirstName= entity.FirstName,
            LastName= entity.LastName,
            Email= entity.Email,

        };

    }
}
