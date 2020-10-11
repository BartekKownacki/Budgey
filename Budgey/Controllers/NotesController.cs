using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Budgey.Models;
using Microsoft.AspNetCore.Mvc;

namespace Budgey.Controllers
{
    public class NotesController : Controller
    {
        public IActionResult AllNotes()
        {
            List<Note> notes = new List<Note>();
            notes.Add(new Note { Id = 1, Title = "aaa", Content = "bbbb", ShortContent = "b" });
            notes.Add(new Note { Id = 2, Title = "aaa", Content = "bbbb", ShortContent = "b" });
            notes.Add(new Note { Id = 3, Title = "aaa", Content = "bbbb", ShortContent = "b" });
            return View(notes);
        }

        public IActionResult Details(int id)
        {
            List<Note> notes = new List<Note>();
            notes.Add(new Note { Id = 1, Title = "aaa", Content = "bbbb", ShortContent = "b" });
            notes.Add(new Note { Id = 2, Title = "aaa", Content = "bbbb", ShortContent = "b" });
            notes.Add(new Note { Id = 3, Title = "aaa", Content = "bbbb", ShortContent = "b" });

            return View(notes.Where(p => p.Id == id));
        }
    }
}
