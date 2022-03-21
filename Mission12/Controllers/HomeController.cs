﻿using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Index() //what to return when Index page is requested
        {
            return View();
        }

        public IActionResult SignUp() //what to return when SignUp page is requested
        {
            return View();
        }

        public IActionResult ViewAppointments() //what to return when ViewAppointments page is requested
        {
            return View();
        }
    }
}
