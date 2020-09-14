using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ITMO.ASP.NET.MVC.Stud_grades.Models
{
    public class PersonContext:DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}