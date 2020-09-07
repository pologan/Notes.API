using System;
using System.ComponentModel.DataAnnotations;

namespace Notes.API.Models
{
    public class Note
    {
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime AddDate { get; set; }
    }
}
