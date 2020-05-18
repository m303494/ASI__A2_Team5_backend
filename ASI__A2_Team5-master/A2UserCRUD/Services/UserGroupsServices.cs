using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A2UserCRUD.Services
{
    public class UserGroupsServices : IUserGroups
    {
        private List<UserGroups> _UGs;

        public UserGroupsServices()
        {
            _UGs = new List<UserGroups>();
        }

        public UserGroups AddUserGroup(UserGroups userGroup)
        {
            _UGs.Add(userGroup);
            return userGroup;
            throw new NotImplementedException();
        }

        public string DeleteUserGroup(string id)
        {
            for (var index = _UGs.Count - 1; index >= 0; index--)
            {
                if (_UGs[index].User_id == id)
                {
                    _UGs.RemoveAt(index);
                }
            }

            return id;
            throw new NotImplementedException();
        }

        public List<UserGroups> GetUserGroups()
        {
            return _UGs;
            throw new NotImplementedException();
        }

        public UserGroups UpdateUserGroup(string id, UserGroups userGroups)
        {
            for (var index = _UGs.Count - 1; index >= 0; index--)
            {
                if (_UGs[index].User_id == id)
                {
                    _UGs[index] = userGroups;
                }
            }
            return userGroups;
            throw new NotImplementedException();
        }
    }
}
