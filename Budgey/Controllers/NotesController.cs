using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Budgey.Application.Interfaces;
using Budgey.Application.Services;
using Budgey.Application.ViewModels.Notes;
using Budgey.Models;
using Microsoft.AspNetCore.Mvc;

namespace Budgey.Controllers
{
    public class NotesController : Controller
    {
        private readonly INoteService _noteService;
        public NotesController(INoteService noteService)
        {
            _noteService = noteService;
        }
        public IActionResult Index()
        {
            //utworzyć widok
            //tabela z notatkami 
            //panel do filtrowania

            //przygotowanie listy notatek 

            var model = _noteService.GetAllNotesForList();
            return View(model);
        }

        [HttpGet]
        public IActionResult AddNote()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNote(NewNoteVm model)
        {
            var id = _noteService.AddNote(model);
            return View();
        }

        public IActionResult ViewNote(int id)
        {
            var model = _noteService.GetNoteDetails(id);
            return View(model);
        }
    }
}
