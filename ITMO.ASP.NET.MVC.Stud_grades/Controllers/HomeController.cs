using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITMO.ASP.NET.MVC.Stud_grades.Models;

namespace ITMO.ASP.NET.MVC.Stud_grades.Controllers
{
    public class HomeController : Controller
    {
        private PersonContext db = new PersonContext();
        
        public ActionResult Index()
        {
            var allPersons = db.Persons.ToList<Person>();
            ViewBag.Persons = allPersons;
            return View();
        }


        public ActionResult Top5()
        {
            var allPers = db.Persons.ToList<Person>();
            var sor = allPers.OrderByDescending(x => x.Grade);
            ViewBag.Message = "Пять лучших студентов";
            ViewBag.Persons = sor.Take(5);

            

            return View();
        }

        public ActionResult Down5()
        {
            var allPers = db.Persons.ToList<Person>();
            var sor = allPers.OrderBy(x => x.Grade);
            ViewBag.Message = "Пять лучших студентов";
            ViewBag.Persons = sor.Take(5);



            return View();
        }
    }
}