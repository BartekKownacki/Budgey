using Budgey.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Budgey.Domain.Interfaces
{
    public interface IUserRepository
    {
        int AddUser(User user);
        void DeleteUser(int id);
        decimal IncreaseBudget(int id, int value);
        decimal DecreaseBudget(int id, int value);
        int EditUser(User user);

        IQueryable<User> GetAllUsers();
        User GetSpecifiedUser(int id);

    }
}
