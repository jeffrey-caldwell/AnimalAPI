﻿using AnimalAPI.Models.Breeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalAPI.Models.Dtos.Notes
{
    public class UpdatedNoteDto
    {
        public int Id { get; set; }
        public bool Medical { get; set; } = false;
        public string Title { get; set; }
        public string Body { get; set; }

        public int? BreedingRecordId { get; set; }
        public int? ContactId { get; set; }
    }
}
