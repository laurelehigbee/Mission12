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
        //* INDEX PAGE *//
        public IActionResult Index()
        {
            return View();
        }
        //* ADD *//

        [HttpGet]
        //once the SignUp page is finished replace current IActionResult with the following line
        //public IActionResult Form(string date, string time)
        public IActionResult Form()
        {
            //Once the IActionResult that passes in the date and time is used, uncomment the code below.
            //ViewBag.Date = date;
            //ViewBag.Time = time;
            return View(new AppointmentInfo());
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
