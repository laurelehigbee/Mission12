using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models.ViewModels
{
    public class TimeSlotsViewModel
    {
        public List<DateTime> Days { get; set; }
        public List<int> Times { get; set; }

        public DateTime Date { get; set; }
        public int Time { get; set; }

        public List<AppointmentInfo> CurrentApts { get; set; }

    }
}
