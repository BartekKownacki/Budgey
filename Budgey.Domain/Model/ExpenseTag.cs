using System;
using System.Collections.Generic;
using System.Text;

namespace Budgey.Domain.Model
{
    public class ExpenseTag
    {
        public int ExpenseId { get; set; }
        public Expense Expense { get; set; }
        public int TagId { get; set; } 
        public Tag Tag { get; set; }
    }
}
