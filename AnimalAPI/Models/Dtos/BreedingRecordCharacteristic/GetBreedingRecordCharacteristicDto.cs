﻿using AnimalAPI.Models.Breeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalAPI.Models.Dtos.BreedingRecordCharacteristic
{
    public class GetBreedingRecordCharacteristicDto
    {
        public int BreedingRecordId { get; set; }
        //public BreedingRecord BreedingRecord { get; set; }

        public int CharacteristicId { get; set; }
        //public Characteristic Characteristic { get; set; }
    }
}
