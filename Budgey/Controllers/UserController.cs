using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Budgey.Models;
using Microsoft.AspNetCore.Mvc;

namespace Budgey.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Details(int id)
        {
            List<User> listOfUsers = new List<User>();
            listOfUsers.Add(new User { Id = 1, NickName = "John", Password = "xyz", Email = "John.Doe@mail.com" });
            listOfUsers.Add(new User { Id = 2, NickName = "Adam", Password = "xyz", Email = "Adam.Doe@mail.com" });
            listOfUsers.Add(new User { Id = 3, NickName = "Steve", Password = "xyz", Email = "Steve.Doe@mail.com" });
            return View(listOfUsers.Where(p => p.Id == id));
        }

        public IActionResult AllUsers()
        {
            List<User> listOfUsers = new List<User>();
            listOfUsers.Add(new User { Id = 1, NickName = "John", Password = "xyz", Email = "John.Doe@mail.com" });
            listOfUsers.Add(new User { Id = 2, NickName = "Adam", Password = "xyz", Email = "Adam.Doe@mail.com" });
            listOfUsers.Add(new User { Id = 3, NickName = "Steve", Password = "xyz", Email = "Steve.Doe@mail.com" });
            return View(listOfUsers);
        }
    }
}
