using UserProvider.Business.Models;

namespace UserProvider.Business.Interfaces;

public interface IUserRepository
{
    public UserRepositoryResult Save(UserEntity entity);
    User GetOneUser(string UserId);
}
