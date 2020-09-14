using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITMO.ASP.NET.MVC.Stud_grades.Models
{
    public class Person
    {
        // ID
        public virtual int PersonId { get; set; }
        // Фамилия
        [DisplayName("Фамилия")]
        [Required]
        public virtual string Surname { get; set; }
        // Имя
        [DisplayName("Имя")]
        [Required]
        public virtual string Name { get; set; }
        // Оценка
        [DisplayName("Оценка")]
        public virtual int Grade { get; set; }
    }
}