using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Budgey.Models;
using Microsoft.AspNetCore.Mvc;

namespace Budgey.Controllers
{
    public class BudgetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BudgetInfo(int id)
        {
            List<Budget> ListOfBudget = new List<Budget>();
            ListOfBudget.Add(new Budget { Id = 1, UserId = 1, Amount = 30, Currency = "Euro" });
            ListOfBudget.Add(new Budget { Id = 2, UserId = 2, Amount = 20, Currency = "Dollars" });
            ListOfBudget.Add(new Budget { Id = 3, UserId = 3, Amount = 10, Currency = "Pesos" });
            ListOfBudget.Add(new Budget { Id = 4, UserId = 1, Amount = 40, Currency = "Euro" });

            return View(ListOfBudget.Where(p => p.UserId == id));
        }
    }
}
