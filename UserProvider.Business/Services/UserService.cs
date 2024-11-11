using UserProvider.Business.Factories;
using UserProvider.Business.Interfaces;
using UserProvider.Business.Models;

namespace UserProvider.Business.Services;

public class UserService : IUserService
{
    private readonly IUserValidator _userValidator;
    private readonly IUserRepository _userRepository;
    private List<User> _users = [];

    public UserService(IUserValidator userValidator, IUserRepository userRepository)
    {
        _userValidator = userValidator;
        _userRepository = userRepository;
    }

    public UserServiceResult CreateUser(UserRequest request)
    {

        var validatorResult = _userValidator.Validate(request);
        if (validatorResult.Success)
        {
            var userEntity = UserFactory.Create(request);
            if(userEntity != null)
            {
                var repositoryResult = _userRepository.Save(userEntity);

                if (repositoryResult.Success)
                {
                    var user = UserFactory.Create(userEntity);
                    var serviceResult = new UserServiceResult { Success = true };
                    return serviceResult;

                }
            }
        }
        var serviceResultError = new UserServiceResult { Success = false };
        return serviceResultError;

    }


    public List<User> GetAll()
    {
        return _users;
    }

    public void AddUser(User user)
    {
        _users.Add(user);
    }

    public User GetOneUser(string UserId)
    {
        return _users.FirstOrDefault(x => x.UserId == UserId);
    }

    public void UpdateUserEmail(string UserId, string newEmail)
    {
        var user = _userRepository.GetOneUser(UserId);
        if (user != null)
        {
            user.Email = newEmail;
        }
    }

    public UserServiceResult DeleteOne(Func<User, bool> predicate)
    {
        throw new NotImplementedException();
    }
}
