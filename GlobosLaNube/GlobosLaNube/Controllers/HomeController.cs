﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GlobosLaNube.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "¿Quienes somos?";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contactanos";

            return View();
        }
    }
}