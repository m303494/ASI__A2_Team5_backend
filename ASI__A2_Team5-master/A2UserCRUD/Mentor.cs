using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A2UserCRUD
{
    public class Mentor
    {
        public int Mentor_id { get; set; }
        public int User_id { get; set; }
        public String Qualification { get; set; }
        public int Year_attended { get; set; }
        public String Application_Motivation { get; set; }
    }
}
