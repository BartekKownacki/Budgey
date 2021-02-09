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
        private readonly NoteService _noteService;
        public IActionResult Index()
        {
            //utworzyć widok
            //tabela z notatkami 
            //panel do filtrowania

            //przygotowanie listy notatek 

            var model = noteService.GetAllNotesForList();
            return View(model);
        }

        [HttpGet]
        public IActionResult AddNote()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNote(NoteModel model)
        {
            var id = noteService.AddNote(model);
            return View();
        }

        public IActionResult ViewNote(int id)
        {
            var model = noteService.GetNoteDetails(id);
            return View(model);
        }
    }
}
