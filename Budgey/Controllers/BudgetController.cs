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

    }
}
