using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StronaZespol.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
        
            //Udaje ze mam baze danych:
            List<DateTime> reservationDateTimes = new List<DateTime>();
            reservationDateTimes.Add(DateTime.Now);
            reservationDateTimes.Add(DateTime.Now.AddHours(1));
            reservationDateTimes.Add(DateTime.Now.AddHours(-2));
            reservationDateTimes.Add(DateTime.Now.AddDays(1));
           
            return View(reservationDateTimes);
        }
        public ActionResult Gallery()
        {
            return View();
        }
        public ActionResult Video()
        {
            return View();
        }


    }
}