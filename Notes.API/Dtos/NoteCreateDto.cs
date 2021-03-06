﻿using System;
using System.ComponentModel.DataAnnotations;

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
