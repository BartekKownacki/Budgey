using System;
using System.Collections.Generic;
using System.Text;

namespace Budgey.Domain.Model
{
    public class User 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public ICollection<Expense> Expenses { get; set; }
        public ICollection<Note> Notes { get; set; }

        public virtual ICollection<ContactDetail> ContactDetails { get; set; }
    }
}
