using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission12.Models;
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

        public IActionResult Index() //what to return when Index page is requested
        {
            return View();
        }

        public IActionResult SignUp() //what to return when SignUp page is requested
        {
            return View();
        }
        //* ADD *//

        [HttpGet]
        //public IActionResult Form(string date, string time)
        public IActionResult Form()
        {
            //How are we wanting to pass in the date and time?
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
        public IActionResult Edit(int tourid) //Page to Edit forms
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
