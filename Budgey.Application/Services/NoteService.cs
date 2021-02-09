using AutoMapper;
using AutoMapper.QueryableExtensions;
using Budgey.Application.Interfaces;
using Budgey.Application.ViewModels.Notes;
using Budgey.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Budgey.Application.Services
{
    public class NoteService : INoteService
    {
        private readonly INoteRepository _noteRepository;
        private readonly IMapper _mapper;
        public NoteService(INoteRepository noteRepository, IMapper mapper)
        {
            _noteRepository = noteRepository;
            _mapper = mapper;
        }
        public int AddNote(NewNoteVm note)
        {
            
            
        }

        public ListNotesForListVm GetAllNotesForList()
        {
            var notes = _noteRepository.GetAllNotes()
                .ProjectTo<NotesForListVm>(_mapper.ConfigurationProvider).ToList();
            
            var notesList = new ListNotesForListVm()
            {
                Notes = notes,
                Count = notes.Count
            };

            return notesList;


/*            ListNotesForListVm result = new ListNotesForListVm();
            result.Notes = new List<NotesForListVm>();
            foreach(var note in notes)
            {
                var noteVm = new NotesForListVm()
                {
                    Id = note.Id,
                    Title = note.Title,
                    ShortContent = note.ShortContent,
                };
                result.Notes.Add(noteVm);
            }
            result.Count = result.Notes.Count;
            return result;*/
        }

        public NoteDetailsVm GetNoteDetails(int id)
        {
            var note = _noteRepository.GetNoteById(id);

            var noteVm = _mapper.Map<NoteDetailsVm>(note);

            return noteVm;
        }
    }
}
