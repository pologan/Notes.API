using Microsoft.AspNetCore.Mvc;
using Notes.API.Data;
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

        public NotesController(INotesRepo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Note>> GetAllNotes()
        {
            var noteItems = _repository.GetAppNotes();

            return Ok(noteItems);
        }

        [HttpGet("{id}")]
        public ActionResult<Note> GetNoteById(int id)
        {
            var noteItem = _repository.GetNoteById(id);

            return Ok(noteItem);
        }
    }
}
