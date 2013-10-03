using System;
using System.Linq;
using System.Web.Mvc;
using CoffeeConsumption.Managers;
using CoffeeConsumption.Models;
using Core;

namespace CoffeeConsumption.Controllers
{
    public class HomeController : Controller
    {
        private readonly OfficeContext db = new OfficeContext();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Login(User user)
        {
            var currentUser =
                db.Users.FirstOrDefault(
                    u =>
                    u.Email.ToLower()
                     .Equals(user.Email.ToLower()) && u.Password.ToLower().Equals(user.Password.ToLower()));
            if (currentUser != null)
            {
                SessionManager.SetCurrentUserID(currentUser.Id);
                var cups = db.Cups.ToList();
                return View("GetBeverage", cups);
            }
            return View("Login", user);
        }

        [HttpGet]
        public ActionResult GetBeverage()
        {
            var cups = db.Cups.ToList();
            return View("GetBeverage", cups);
        }
        
        [HttpPost]
        public ActionResult GetBeverage(Cup cup)
        {
            var userId = SessionManager.GetCurrentUserId();
            if (!userId.HasValue)
            {
                return RedirectToAction("Login", "Home");
            }
            var consumption = new Consumption
                {
                    UserId = userId.Value,
                    CupId = cup.Id,
                    BeverageTime = DateTime.Now
                };
            db.Consumptions.Add(consumption);
            db.SaveChanges();

            return Json(CCResponse.Succeded());
        }
    }
}
