using AutoMapper;
using Budgey.Application.Mapping;
using Budgey.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Budgey.Application.ViewModels.Notes
{
    public class NotesForListVm : IMapFrom<Note>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortContent { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Note, NotesForListVm>();
/*                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.Title, opt => opt.MapFrom(s => s.Title))
                .ForMember(d => d.ShortContent, opt => opt.MapFrom(s => s.ShortContent));*/
        }
    }
}
