using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class Lucky7Controller : Controller
    {
        // GET: Lucky7
        public ActionResult Index(int luck = 7)
        {
            Random rnd = new Random();
            int lucky = luck;
            int a = rnd.Next(0, 10);
            int b = rnd.Next(0, 10);
            int c = rnd.Next(0, 10);

            var display = "none";


           if (a == lucky || b == lucky || c == lucky)
            {
                 display = "block";
            }

            
            ViewBag.number = lucky;
            ViewBag.first = a;
            ViewBag.sec = b;
            ViewBag.third = c;
            ViewBag.display = display;
            return View();
        }
    }
}