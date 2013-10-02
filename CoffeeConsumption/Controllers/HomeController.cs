using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoffeeConsumption.Models;

namespace CoffeeConsumption.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Login(User user)
        {
            var cups = new List<Cup>
                {
                    new Cup {beverageType = BeverageType.Coffee},
                    new Cup {beverageType = BeverageType.Tea},
                    new Cup {beverageType = BeverageType.Juice}
                };
            return View("GetBeverage", cups);
        }

        [HttpGet]
        public ActionResult Beverage()
        {
            var cups = new List<Cup>
                {
                    new Cup {beverageType = BeverageType.Coffee},
                    new Cup {beverageType = BeverageType.Tea},
                    new Cup {beverageType = BeverageType.Juice}
                };
            return View("GetBeverage", cups);
        }
        
    }
}
