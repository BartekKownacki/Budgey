using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Budgey.Models
{
    public class Budget
    {
        [DisplayName("Identity")]
        public int Id { get; set; }
        [DisplayName("User identity")]
        public int UserId { get; set; }
        public int Amount { get; set; }
        public string Currency { get; set; }
    }
}
