using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Notes.API.Data;
using Notes.API.Dtos;
using Notes.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes.API.Controllers
{
    [Route("api/notes")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly INotesRepo _repository;
        private readonly IMapper _mapper;

        public NotesController(INotesRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<NoteReadDto>> GetAllNotes()
        {
            var noteItems = _repository.GetAllNotes();

            return Ok(_mapper.Map<IEnumerable<NoteReadDto>>(noteItems));
        }

        [HttpGet("{id}", Name = "GetNoteById")]
        public ActionResult<NoteReadDto> GetNoteById(int id)
        {
            var noteItem = _repository.GetNoteById(id);

            if (noteItem != null)
            {
                return Ok(_mapper.Map<NoteReadDto>(noteItem));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<NoteReadDto> CreateNote(NoteCreateDto noteCreateDto)
        {
            var noteModel = _mapper.Map<Note>(noteCreateDto);
            _repository.CreateNote(noteModel);
            _repository.SaveChanges();

            var noteReadDto = _mapper.Map<NoteReadDto>(noteModel);

            return CreatedAtRoute(nameof(GetNoteById), new { Id = noteReadDto.Id }, noteReadDto);
        }
    }
}
