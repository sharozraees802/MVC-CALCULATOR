using Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculator.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View(new calc());
        }

        [HttpPost]
        public ActionResult Index(calc c,string calculator)
        {
            if (calculator == "add")
            {
                c.tot = c.no1 + c.no2;

            }
           else if (calculator == "sub")
            {
                c.tot = c.no1 - c.no2;

            }
            else if (calculator == "mul")
            {
                c.tot = c.no1 * c.no2;

            }
            else 
            {
                c.tot = c.no1 / c.no2;

            }
            return View(c);

        }



    }
}