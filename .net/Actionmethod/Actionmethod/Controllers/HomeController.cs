﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Actionmethod.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public string show()
        {
            return "This is a second action method of home controller";
        }
        public int StudentId(int id)
        {
            return id;
        }
    }
}