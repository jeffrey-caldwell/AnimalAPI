﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalAPI.Models.Dtos.BreedingRecordCharacteristic
{
    public class CreateBreedingRecordCharacteristicDto
    {
        public int BreedingRecordId { get; set; }
        public int CharacteristicId { get; set; }
    }
}
