using System;
using System.Collections.Generic;
using System.Runtime.Caching;


namespace TddApp.TestObjectTypes.Fake
{
    /// <summary>
    /// Fake objects actually have working implementations, but usually take some shortcut which makes
    /// them not suitable for production (an in memory database is a good example).
    /// </summary>
    public class FakeExample : IUserDatabase
    {
        private const string USER_LIST_KEY = "Users";        
        private MemoryCache _cache = new MemoryCache("MyCache");

        public void Initialise()
        {
            throw new NotImplementedException();
        }

        public void AddUserToDb(User user)
        {
            List<User> userList;

            if (!(this._cache[USER_LIST_KEY] is List<User>))
            {
                userList = new List<User>() { user };
                this._cache.Add(USER_LIST_KEY, userList, DateTimeOffset.MaxValue);
            }
            else
            {
                userList = this._cache[USER_LIST_KEY] as List<User>;
                if (!userList.Contains(user))
                {
                    userList.Add(user);
                    this._cache[USER_LIST_KEY] = userList;
                }
            }
        }

        public List<User> GetAllUsersFromDb()
        {
            return this._cache[USER_LIST_KEY] as List<User>;            
        }

        public User GetUserById(int Id)
        {
            throw new NotImplementedException();
        }

    }
}
