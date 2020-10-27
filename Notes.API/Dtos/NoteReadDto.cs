using System;
using System.ComponentModel.DataAnnotations;

namespace Notes.API.Dtos
{
    public class NoteReadDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime AddDate { get; set; }
    }
}
