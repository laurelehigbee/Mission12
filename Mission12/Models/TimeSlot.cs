﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class TimeSlot
    {
        [Key]
        public int TimeSlotId { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }

    }
}