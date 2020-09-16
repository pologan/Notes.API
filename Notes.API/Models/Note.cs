using System;
using System.ComponentModel.DataAnnotations;

namespace Notes.API.Models
{
    public class Note
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime AddDate { get; set; }
    }
}
