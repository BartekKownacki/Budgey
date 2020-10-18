using Budgey.Domain.Interfaces;
using Budgey.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Budgey.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly Context _context;

        public UserRepository(Context context)
        {
            _context = context;
        }
        
        public int AddUser(User user)
        {
            _context.Users.Add(user);
            return user.Id;
        }

        public decimal DecreaseBudget(int id, int value)
        {
            _context.Users.FirstOrDefault(p => p.Id == id).Budget = _context.Users.FirstOrDefault(p => p.Id == id).Budget - value;
            _context.SaveChanges();
            return _context.Users.FirstOrDefault(p => p.Id == id).Budget;
        }

        public void DeleteUser(int id)
        {
            var user = _context.Users.Find(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }

        public int EditUser(User user)
        {
            _context.Users.FirstOrDefault(p => p.Id == user.Id).Id = user.Id;
            _context.Users.FirstOrDefault(p => p.Id == user.Id).Name = user.Name;
            _context.Users.FirstOrDefault(p => p.Id == user.Id).Budget = user.Budget;
            _context.Users.FirstOrDefault(p => p.Id == user.Id).Expenses = user.Expenses;
            _context.Users.FirstOrDefault(p => p.Id == user.Id).ContactDetails = user.ContactDetails;
            _context.SaveChanges();
            return user.Id;
        }

        public IQueryable<User> GetAllUsers()
        {
            IQueryable<User> users = _context.Users;
            return users;
        }

        public User GetSpecifiedUser(int id)
        {
            var user = _context.Users.FirstOrDefault(p => p.Id == id);
            return user;
        }

        public decimal IncreaseBudget(int id, int value)
        {
            _context.Users.FirstOrDefault(p => p.Id == id).Budget = _context.Users.FirstOrDefault(p => p.Id == id).Budget + value;
            _context.SaveChanges();
            return _context.Users.FirstOrDefault(p => p.Id == id).Budget;
        }
    }
}
