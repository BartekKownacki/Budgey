using Budgey.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Budgey.Domain.Interfaces
{
    public interface INoteRepository
    {
        void DeleteNote(int id);

        int AddNote(Note note);

        IQueryable<Note> GetAllNotes();

        Note GetNoteById(int id);
    }
}
