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
        public DateTime AptDate { get; set; }
        [Required]
        public int AptTime { get; set; }
        [Required(ErrorMessage = "Please enter your group's name:")]
        public string GroupName { get; set; }
        [Required(ErrorMessage = "Please enter a number between 1 and 15:")]
        [Range(1, 15)] //sets range of people between 1 and 15
        public int Size { get; set; } 
        [Required(ErrorMessage = "Please enter an email:")]
        public string Email { get; set; }
        public string Phone { get; set; }


    }
}

