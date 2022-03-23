using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class EFTimeSlotRepository : ITimeSlotRepository
    {

        private TimeSlotContext context { get; set; }
        public EFTimeSlotRepository (TimeSlotContext temp)
        {
            context = temp;
        }
        public IQueryable<TimeSlot> Slots => context.Slots;
    }
}
