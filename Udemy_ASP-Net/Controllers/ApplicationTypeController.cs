﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Udemy_ASP_Net.Controllers
{
    public class ApplicationTypeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
