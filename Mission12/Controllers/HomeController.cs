using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission12.Models;
using Mission12.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Controllers
{
    public class HomeController : Controller
    {
        private AppointmentContext AptCon { get; set; }
        private ITimeSlotRepository repo;

        public HomeController(AppointmentContext appointmentContext , ITimeSlotRepository temp) //constructor that passes context instance
        {
            AptCon = appointmentContext;
            repo = temp;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            var x = new TimeSlotsViewModel
            {
                Slots=repo.Slots
                
            };

            return View(x);

        }

        public IActionResult Index() //what to return when Index page is requested
        {
            return View();
        }

        [HttpGet]
        public IActionResult ViewAppointments() //what to return when ViewAppointments page is requested
        {
            var appointments=AptCon.Responses.ToList();
            return View(appointments);
        }

        [HttpGet]
        public IActionResult Delete(int tourid) //what to return when delete is selected
        {
            var appointment=AptCon.Responses.Single(x=>x.TourId==tourid);
            return View(appointment);
        }

        [HttpPost]
        public IActionResult Delete(AppointmentInfo apt) //what to return when appointment is confirmed and needs to be deleted
        {
            AptCon.Responses.Remove(apt);
            AptCon.SaveChanges();

            return RedirectToAction("ViewAppointments");
        }

    }
}
