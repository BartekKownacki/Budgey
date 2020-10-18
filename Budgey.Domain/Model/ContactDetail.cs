using System;
using System.Collections.Generic;
using System.Text;

namespace Budgey.Domain.Model
{
    public class ContactDetail
    {
        public int Id { get; set; }
        public string ContactDetailInformation { get; set; }
        public int ContactDetailTypeId { get; set; }
        public ContactDetailType ContactDetailType { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
