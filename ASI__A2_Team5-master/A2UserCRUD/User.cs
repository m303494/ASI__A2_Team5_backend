    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A2UserCRUD
{
    public class User
    {
        public int User_id { get; set; }
        public String Username { get; set; }
        public String Gender { get; set; }
        public String Nationality { get; set; }
        public String Password { get; set; }
        public String Birthdate { get; set; }
        public int Course_id { get; set; }
    }
}
