using System.Collections.Generic;

namespace TddApp.TestObjectTypes.Fake
{
    public class FakeExampleProgram
    {
        private readonly IUserDatabase _userDatabase;

        public FakeExampleProgram(IUserDatabase userDb)
        {
            this._userDatabase = userDb;
        }

        public void AddUser(User user)
        {
            this._userDatabase.AddUserToDb(user);
        }
        public List<User> GetUserList()
        {
            return this._userDatabase.GetAllUsersFromDb();
        }
    }
}