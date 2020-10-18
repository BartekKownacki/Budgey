using Budgey.Domain.Interfaces;
using Budgey.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Budgey.Infrastructure.Repositories
{
    public class ExpenseRepository : IExpenseRepository
    {
        private readonly Context _context;
        public ExpenseRepository(Context context)
        {
            _context = context;
        }

        public void DeleteExpense(int expenseId)
        {
            var expense = _context.Expenses.Find(expenseId);
            if (expense!= null)
            {
                _context.Expenses.Remove(expense);
                _context.SaveChanges();
            }
        }

        public int AddExpense(Expense expense)
        {
            _context.Expenses.Add(expense);
            _context.SaveChanges();
            return expense.Id;
        }

        public IQueryable<Expense> GetExpensesByTypeId(int typeId)
        {
            var filteredExpenses = _context.Expenses.Where(e => e.TypeId == typeId);
            return filteredExpenses;
        }

        public Expense GetExpenseById(int expenseId)
        {
            var expense = _context.Expenses.FirstOrDefault(e => e.Id == expenseId);
            return expense;
        }

        public IQueryable<Tag> GetAllTags()
        {
            var tags = _context.Tags;
            return tags;
        }

        public IQueryable<Domain.Model.Type> GetAllTypes()
        {
            var types = _context.Types;
            return types;
        }
    }
}
