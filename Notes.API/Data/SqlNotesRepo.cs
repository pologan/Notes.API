using Notes.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes.API.Data
{
    public class SqlNotesRepo : INotesRepo
    {
        private readonly NotesContext _context;

        public SqlNotesRepo(NotesContext context)
        {
            _context = context;
        }

        public IEnumerable<Note> GetAllNotes()
        {
            return _context.Notes.ToList();
        }

        public Note GetNoteById(int id)
        {
            return _context.Notes.FirstOrDefault(n => n.Id == id);
        }
    }
}
