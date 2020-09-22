using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Notes.API.Dtos
{
    public class NoteCreateDto
    {
        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime AddDate { get; set; }
    }
}
