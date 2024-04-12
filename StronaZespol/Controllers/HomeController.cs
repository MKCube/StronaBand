using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StronaZespol.Controllers
{
    public class HomeController : Controller
    {
        private const string  V =  "Kontakt z Zespołem";

        //public ActionResult Index()
        //{
        //    return View();
        //}
       
       // public ActionResult About()
       // {
       //     pobrac dane
       //     MaciekEntities db = new MaciekEntities();
       //     List<Klient> klienci = db.Klient.ToList();
       //
       //
       //     przekazac do widoku
       //     return View(klienci);
       // }

        public ActionResult Contact()
        {
            ViewBag.Message = V;

            return View();
        }
    }

    internal class MaciekEntities
    {
        public MaciekEntities()
        {
        }
   
        public object Klient { get; internal set; }
    }
}