using System.Collections.Generic;

namespace TddApp.TestObjectTypes.Fake
{
    public interface IUserDatabase
    {
        void Initialise();
        void AddUserToDb(User user);
        List<User> GetAllUsersFromDb();
        User GetUserById(int Id);

    }
}