﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Area.Areas.Teacher.Controllers
{
    public class HomeController : Controller
    {
        // GET: Teacher/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}