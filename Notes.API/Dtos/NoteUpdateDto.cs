using System;
using System.ComponentModel.DataAnnotations;

namespace Notes.API.Dtos
{
    public class NoteUpdateDto
    {
        [Required]
        public string Content { get; set; }
    }
}
