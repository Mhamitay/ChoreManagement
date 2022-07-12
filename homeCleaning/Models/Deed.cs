﻿using HomeCleaningLib.Enums;
using HomeCleaningLib.interfaces;

namespace HomeCleaningLib.Models
{
    public class Deed : IDeed
    {
        public int id { get; set; }
        public string name { get; set; }
        public DeedType deedType { get; set; }
    }
}
 