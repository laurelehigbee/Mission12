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

        public HomeController(AppointmentContext appointmentContext) //constructor that passes context instance
        {
            AptCon = appointmentContext;
        }

        [HttpGet]
        public IActionResult SignUp()
        {

            var schedulableDays = new List<DateTime>();
            var schedulableTimes = new List<int>();

            var now = DateTime.Now;
            // Get an integer indicating how many days are between now and 3 months from now
            int offset = (now.AddMonths(3) - now).Days;

            // Load up 3 months worth of days
            for (int i = 0; i <= offset; i++)
            {
                schedulableDays.Add(now.AddDays(i));
            }

            //Load up the times
            for (int i = 8; i < 21; i ++)
            {
                // This isn't very readable, but it's pretty fun.
                // It chooses a suffix (am or pm) and converts 24-hour time (for looping) to 12-hour time.
                schedulableTimes.Add(i);
            }

            var vm = new TimeSlotsViewModel
            {
                Days = schedulableDays,
                Times = schedulableTimes

            };

            // set the "CurrentApts" attribute of the TimeSlotsViewModel to the retrieved list of all the appointments that have been made (as seen in the context file referenced below)
            vm.CurrentApts = AptCon.Responses.ToList();

            return View(vm);

        }
        //* INDEX PAGE *//
        public IActionResult Index()
        {
            return View();
        }
        //* ADD *//

        [HttpGet]
        //once the SignUp page is finished replace current IActionResult with the following line
        //public IActionResult Form(string date, string time)
        public IActionResult Form(TimeSlotsViewModel ts)
        {
            // instantiate 
            var apt = new AppointmentInfo();
            apt.AptDate = ts.Date;
            apt.AptTime = ts.Time;
            return View(apt);

        }
        [HttpPost]
        public IActionResult Form(AppointmentInfo appointmentInfo)
        {
            if (ModelState.IsValid)
            {
                AptCon.Add(appointmentInfo);
                AptCon.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(appointmentInfo);
            }
        }
        [HttpGet]
        //* EDIT *//
        public IActionResult Edit(int tourid)
        {
            var apt = AptCon.Responses.Single(x => x.TourId == tourid);
            return View(apt);
        }
        [HttpPost]
        public IActionResult Edit(AppointmentInfo appointmentInfo)
        {
            AptCon.Responses.Update(appointmentInfo);
            AptCon.SaveChanges();
            return RedirectToAction("Index");
        }
        //* VIEW APPOINTMENTS *//
        [HttpGet]
        public IActionResult ViewAppointments()
        {
            var appointments=AptCon.Responses.ToList();
            return View(appointments);
        }
        //* DELETE *//

        [HttpGet]
        public IActionResult Delete(int tourid)
        {
            var appointment=AptCon.Responses.Single(x=>x.TourId==tourid);
            return View(appointment);
        }

        [HttpPost]
        public IActionResult Delete(AppointmentInfo apt)
        {
            AptCon.Responses.Remove(apt);
            AptCon.SaveChanges();

            return RedirectToAction("ViewAppointments");
        }

    }
}
