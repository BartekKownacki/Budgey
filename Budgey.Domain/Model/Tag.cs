using System;
using System.Collections.Generic;
using System.Text;

namespace Budgey.Domain.Model
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ExpenseTag> ExpenseTags { get; set; }
    }
}
