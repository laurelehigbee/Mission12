﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models.ViewModels
{
    public class TimeSlotsViewModel
    {
        public IQueryable<TimeSlot> Slots { get; set; }

    }
}
