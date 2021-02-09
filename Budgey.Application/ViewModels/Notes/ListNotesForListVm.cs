using System;
using System.Collections.Generic;
using System.Text;

namespace Budgey.Application.ViewModels.Notes
{
    public class ListNotesForListVm
    {
        public List<NotesForListVm> Notes { get; set; }
        public int Count { get; set; }
    }
}
