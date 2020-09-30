using Notes.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

        public void CreateNote(Note note)
        {
            if (note == null)
            {
                throw new ArgumentNullException(nameof(note));
            }

            _context.Notes.Add(note);
        }

        public void DeleteNote(Note note)
        {
            if (note == null)
            {
                throw new ArgumentNullException(nameof(note));
            }

            _context.Notes.Remove(note);
        }

        public IEnumerable<Note> GetAllNotes()
        {
            return _context.Notes.ToList();
        }

        public Note GetNoteById(int id)
        {
            return _context.Notes.FirstOrDefault(n => n.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateNote(Note note)
        {

        }
    }
}
