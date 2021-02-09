using AutoMapper;
using Budgey.Application.Mapping;
using Budgey.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Budgey.Application.ViewModels.Notes
{
    public class NoteDetailsVm : IMapFrom<Note>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Note, NoteDetailsVm>();
        }
    }
}
