using Microsoft.EntityFrameworkCore.Update.Internal;
using Notes.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes.API.Data
{
    public interface INotesRepo
    {
        IEnumerable<Note> GetAllNotes();
        Note GetNoteById(int id);

    }
}
