using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A2UserCRUD.Services
{
    public class GroupService : IGroupsService
    {
        private List<Groups> _groups;
        public GroupService()
        {
            _groups = new List<Groups>();
        }

        public Groups AddGroup(Groups group)
        {
            _groups.Add(group);
            return group;
            throw new NotImplementedException();
        }

        public string DeleteGroup(string id)
        {
            for (var index = _groups.Count - 1; index >= 0; index--)
            {
                if (_groups[index].Group_id == id)
                {
                    _groups.RemoveAt(index);
                }
            }

            return id;
            throw new NotImplementedException();
        }

        public List<Groups> GetGroups()
        {
            return _groups;
            throw new NotImplementedException();
        }

        public Groups UpdateGroup(string id, Groups group)
        {
            for (var index = _groups.Count - 1; index >= 0; index--)
            {
                if (_groups[index].Group_id == id)
                {
                    _groups[index] = group;
                }
            }
            return group;
            throw new NotImplementedException();
        }

    }
}
