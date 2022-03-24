using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public interface IAppointmentsRepository
    {
        public IQueryable<AppointmentInfo> Appointments { get; set; }

    }
}
