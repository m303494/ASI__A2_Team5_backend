using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A2UserCRUD
{
    public class Mentee
    {
        public int Mentee_id { get; set; }
        public int User_id { get; set; }
        public int Mentor_id { get; set; }
        public String Qualification { get; set; }
    }
}
