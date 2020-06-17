﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Areas.Manager.Models
{
    [Area("Manager")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}