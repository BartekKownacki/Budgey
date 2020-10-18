using System;
using System.Collections.Generic;
using System.Text;

namespace Budgey.Domain.Model
{
    public class Type
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Expense> Expenses { get; set; }
    }
}
