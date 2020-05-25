using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A2UserCRUD
{
    public class PageContent
    {
        public int Page_id { get; set; }
        public int User_id { get; set; }
        public String Text { get; set; }
        public int Type { get; set; }
        public String Date { get; set; }
        public int Is_deleted { get; set; }
    }

}