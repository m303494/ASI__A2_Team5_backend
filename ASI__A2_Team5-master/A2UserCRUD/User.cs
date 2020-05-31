    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace A2UserCRUD
{
    public class User
    {
        public int User_id { get; set; }
        [Required]
        [StringLength(50)]
        public String Username { get; set; }
        [Required]
        [RegularExpression("Male|Female|Other")]
        public String Gender { get; set; }
        [Required]
        [StringLength(50)]
        public String Nationality { get; set; }
        [Required]
        [StringLength(50)]
        public String Password { get; set; }
        [Required]
        [StringLength(10)] 
        public string Birthdate { get; set; }
        [Required]
        public Nullable<int> Course_id { get; set; }
    }
}
