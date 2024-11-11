using UserProvider.Business.Models;

namespace UserProvider.Business.Interfaces
{
    public interface IUserService
    {
        UserServiceResult CreateUser(UserRequest request);

        public List<User> GetAll();

        public void AddUser(User user);

        public User GetOneUser(string Userid);

        public void UpdateUserEmail(string Userid, string newEmail);


        UserServiceResult DeleteOne(Func<User, bool> predicate);


    }
}
