using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Budgey.Models
{
    public class User
    {
        [DisplayName("Identity")]
        public int Id { get; set; }
        [DisplayName("Nickname")]
        public string NickName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

    }
}
