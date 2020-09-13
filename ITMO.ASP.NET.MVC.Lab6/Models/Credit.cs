using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ITMO.ASP.NET.MVC.Lab5.Models
{
    public class Credit
    {
        // ID кредита 
        public virtual int CreditId { get; set; }
        // Название 
        [DisplayName("Тип кредита")]
        public virtual string Head { get; set; }
        // Период, на который выдается кредит 
        [DisplayName("Период кредитования")]
        public virtual int Period { get; set; }
        // Максимальная сумма кредита 
        [DisplayName("Максимальная ставка")]
        public virtual int Sum { get; set; }
        // Процентная ставка 
        [DisplayName("Процентная ставка")]
        public virtual int Procent { get; set; }
    }
}