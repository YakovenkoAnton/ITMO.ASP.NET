using ITMO.ASP.NET.MVC.Lab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITMO.ASP.NET.MVC.Lab1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public string Index(string hel) 
        {
            string Greeting = ModelClass.ModelHello() + ", " + hel; 
            return Greeting; 
        }


    }
}