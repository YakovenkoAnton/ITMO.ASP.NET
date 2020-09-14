using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ITMO.ASP.NET.MVC.Stud_grades.Models
{
    public class PersonsDbInitializer:DropCreateDatabaseIfModelChanges<PersonContext>
    {
        protected override void Seed(PersonContext context)
        {
           
            context.Persons.Add(new Person { PersonId = 1, Surname = "Иванов", Name = "Иван", Grade = 100 });
            context.Persons.Add(new Person { PersonId = 4, Surname = "Иванbvов", Name = "Иван", Grade = 10 });
            context.Persons.Add(new Person { PersonId = 3, Surname = "Сидоров", Name = "Иван", Grade = 50 });
            base.Seed(context);
        }
    }
}