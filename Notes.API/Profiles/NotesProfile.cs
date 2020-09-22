using AutoMapper;
using Notes.API.Dtos;
using Notes.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes.API.Profiles
{
    public class NotesProfile : Profile
    {
        public NotesProfile()
        {
            CreateMap<Note, NoteReadDto>();
            CreateMap<NoteCreateDto, Note>();
        }
    }
}
