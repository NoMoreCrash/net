using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace OpenNotes.Models
{
    public class NoteModel
    {
        public int NoteId { get; set; }
        [DisplayName("Tytuł")]
        public string Title { get; set; }

        [DisplayName("Treść")]
        public string Content { get; set; }

    }
}