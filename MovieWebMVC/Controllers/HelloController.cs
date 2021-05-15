﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebMVC.Controllers
{
    public class HelloController : Controller
    {
        public string Index()
        {
            return "This is my default action";
        }

        public string Welcome()
        {
            return "This is the welcome action method...";
        }
    }
}