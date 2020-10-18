using System;
using System.Collections.Generic;
using System.Text;

namespace Budgey.Domain.Model
{
    public class Expense
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public int TypeId { get; set; }

        public virtual Type Type { get; set; }
        public ICollection<ExpenseTag> ExpenseTags { get; set; }
    }
}
