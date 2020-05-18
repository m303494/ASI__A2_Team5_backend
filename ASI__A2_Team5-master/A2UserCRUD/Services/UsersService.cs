using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A2UserCRUD.Services
{
    public class UsersService : IUsersService
    {
        private List<User> _users;

        public UsersService()
        {
            _users = new List<User>();
        }

        public User AddUser(User user)
        {
            _users.Add(user);
            return user;
            throw new NotImplementedException();
        }

        public string DeleteUser(string id)
        {
            for (var index = _users.Count - 1; index >= 0; index--)
            {
                if (_users[index].User_id == id)
                {
                    _users.RemoveAt(index);
                }
            }

            return id;
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            return _users;
            throw new NotImplementedException();
        }

        public User UpdateUser(string id, User user)
        {
            for (var index = _users.Count - 1; index >= 0; index--)
            {
                if (_users[index].User_id == id)
                {
                    _users[index] = user;
                }
            }
            return user;
            throw new NotImplementedException();
        }
    }
}
