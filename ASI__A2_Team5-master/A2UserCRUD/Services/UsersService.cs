using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A2UserCRUD;
using System.Linq.Expressions;
using MySql.Data.MySqlClient;

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
            string query = "INSERT INTO user (User_id, Username, Gender, Nationality, Password, Birthdate, Course_id) VALUES(" + user.User_id + ",'" + user.Username + "', '" + user.Gender + "', '" + user.Nationality + "', '" + user.Password + "', '" + user.Birthdate + "', '" + user.Course_id + "')";
            var con = new DBConnect();
            try {
                con.Insert(query);
                return user;
            }
            catch (MySqlException e)
            {
                System.Console.WriteLine(e.Message);
                return null;
            }
            throw new NotImplementedException();
        }

        public string DeleteUser(string id)
        {
            string query = "DELETE FROM user WHERE User_id='" + id + "'";
            var con = new DBConnect();
            con.Delete(query);

            return id;
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            string query = "SELECT * FROM user";
            var con = new DBConnect();
            var result = con.Select(query);
            List<User> _users = result.AsEnumerable().Select(m => new User()
            {
                User_id = m.Field<Int32>("User_id"),
                Username = m.Field<string>("Username"),
                Gender = m.Field<string>("Gender"),
                Nationality = m.Field<string>("Nationality"),
                Password = m.Field<string>("Password"),
                Birthdate = m.Field<string>("Birthdate"),
                Course_id = m.Field<Int32>("Course_id"),
            }).ToList();

            return _users;
            throw new NotImplementedException();
        }

        public User UpdateUser(string id, User user)
        {
            string query = "UPDATE user SET Username='" + user.Username + "', Gender='" + user.Gender + "', Nationality='" + user.Nationality + "', Password='" + user.Password + "', Birthdate='" + user.Birthdate + "', Course_id='" + user.Course_id + "' WHERE User_id='" + id + "'";
            var con = new DBConnect();
            con.Update(query);

            return user;
            throw new NotImplementedException();
        }
    }
}
