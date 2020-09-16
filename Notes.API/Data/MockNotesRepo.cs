using Notes.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes.API.Data
{
    public class MockNotesRepo : INotesRepo
    {
        public IEnumerable<Note> GetAppNotes()
        {
            var notes = new List<Note>
            { new Note { Id = 0, Content = "Chuj w dupie", AddDate = DateTime.Now },
            new Note { Id = 1, Content = "xDDD", AddDate = DateTime.Now },
            new Note { Id = 2, Content = "Lolzz", AddDate = DateTime.Now },
            new Note { Id = 3, Content = "Lorem Ipsum", AddDate = DateTime.Now }};

            return notes;
        }

        public Note GetNoteById(int id)
        {
            return new Note { Id = 0, Content = "Chuj w dupie", AddDate = DateTime.Now };
        }
    }
}
