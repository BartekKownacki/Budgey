using Budgey.Application.ViewModels.Notes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Budgey.Application.Interfaces
{
    public interface INoteService
    {
        ListNotesForListVm GetAllNotesForList();
        int AddNote(NewNoteVm note);
        NoteDetailsVm GetNoteDetails(int id);
    }
}
