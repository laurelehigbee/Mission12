using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class AppointmentInfo //all information relating to an appointment
    {
        [Key]
        [Required] //sets tourid as primary key and required
        public int TourId { get; set; } 
        [Required]
        public string AptDate { get; set; }
        [Required]
        public string AptTime { get; set; }
        [Required]
        public string GroupName { get; set; }
        [Required]
        [Range(1, 15)] //sets range of people between 1 and 15
        public int Size { get; set; } 
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}

