using Budgey.Domain.Interfaces;
using Budgey.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Budgey.Infrastructure.Repositories
{
    public class NoteRepository : INoteRepository
    {
        private readonly Context _context;
        public NoteRepository(Context context)
        {
            _context = context;
        }
        public int AddNote(Note note)
        {
            _context.Notes.Add(note);
            _context.SaveChanges();
            return note.Id;
        }

        public void DeleteNote(int id)
        {
            var note = _context.Expenses.Find(id);
            if (note != null)
            {
                _context.Expenses.Remove(note);
                _context.SaveChanges();
            }
        }

        public IQueryable<Note> GetAllNotes()
        {
            var notes = _context.Notes;
            return notes;
        }

        public Note GetNoteById(int id)
        {
            var note = _context.Notes.FirstOrDefault(e => e.Id == id);
            return note;
        }
    }
}
