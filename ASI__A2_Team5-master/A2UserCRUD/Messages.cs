using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A2UserCRUD
{
    public class Messages
    {
        public int Msg_id { get; set; }
        public int Id_sender { get; set; }
        public int Id_receiver { get; set; }
        public String Content { get; set; }
        public String TimeStamp { get; set; }
    }
}
