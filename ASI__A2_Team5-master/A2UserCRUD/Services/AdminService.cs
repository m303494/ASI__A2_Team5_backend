using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A2UserCRUD.Services
{
    public class AdminService : IAdminsService
    {
        private List<Admin> _admins;

        public AdminService()
        {
            _admins = new List<Admin>();
        }

        public Admin AddAdmin(Admin admin)
        {
            _admins.Add(admin);
            return admin;
            throw new NotImplementedException();
        }

        public string DeleteAdmin(string id)
        {
            for (var index = _admins.Count - 1; index >= 0; index--)
            {
                if (_admins[index].Admin_id == id)
                {
                    _admins.RemoveAt(index);
                }
            }

            return id;
            throw new NotImplementedException();
        }

        public List<Admin> GetAdmins()
        {
            return _admins;
            throw new NotImplementedException();
        }

        public Admin UpdateAdmin(string id, Admin admin)
        {
            for (var index = _admins.Count - 1; index >= 0; index--)
            {
                if (_admins[index].Admin_id == id)
                {
                    _admins[index] = admin;
                }
            }
            return admin;
            throw new NotImplementedException();
        }
    }
}