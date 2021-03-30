﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ElevenNote.Model
{
    public class NoteListItem
    {
        public int NoteId { get; set; }
        public string Title { get; set; }

        [Display(Name="Created")]
        public DateTimeOffset CreatedUTC { get; set; }
    }
}
