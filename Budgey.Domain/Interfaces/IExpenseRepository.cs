using Budgey.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Budgey.Domain.Interfaces
{
    public interface IExpenseRepository
    {
        void DeleteExpense(int expenseId);

        int AddExpense(Expense expense);

        IQueryable<Expense> GetExpensesByTypeId(int typeId);

        Expense GetExpenseById(int expenseId);

        IQueryable<Tag> GetAllTags();

        IQueryable<Domain.Model.Type> GetAllTypes();
    }
}
