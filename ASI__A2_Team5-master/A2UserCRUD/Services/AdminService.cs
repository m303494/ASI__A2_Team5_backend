using System;
using System.Data;
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
            string query = "INSERT INTO admin (Admin_id, User_id) VALUES(" + admin.Admin_id + ",'" + admin.User_id + "')";
            var con = new DBConnect();
            con.Insert(query);

            return admin;
            throw new NotImplementedException();
        }

        public string DeleteAdmin(string id)
        {
            string query = "DELETE FROM admin WHERE Admin_id='" + id + "'";
            var con = new DBConnect();
            con.Delete(query);

            return id;
            throw new NotImplementedException();
        }

        public List<Admin> GetAdmins()
        {
            string query = "SELECT * FROM admin";
            var con = new DBConnect();
            var result = con.Select(query);
            List<Admin> _admins = result.AsEnumerable().Select(m => new Admin()
            {
                Admin_id = m.Field<Int32>("Admin_id"),
                User_id = m.Field<Int32>("User_id")
            }).ToList();

            return _admins;
            throw new NotImplementedException();
        }

        public Admin UpdateAdmin(string id, Admin admin)
        {
            string query = "UPDATE admin SET User_id='" + admin.User_id + "' WHERE Admin_id='" + id + "'";
            var con = new DBConnect();
            con.Update(query);

            return admin;
            throw new NotImplementedException();
        }
    }
}