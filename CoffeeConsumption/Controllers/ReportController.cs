using System.Web.Mvc;
using System.Linq;
using CoffeeConsumption.Managers;
using CoffeeConsumption.Models;
using Core;

namespace CoffeeConsumption.Controllers
{
    public class ReportController : Controller
    {
        private readonly OfficeContext db = new OfficeContext();

        [HttpGet]
        public ActionResult PersonalReport()
        {
            var currentUserId = SessionManager.GetCurrentUserId();
            if (!currentUserId.HasValue)
            {
                return RedirectToAction("Login", "Home");
            }
            var consumptions = db.Consumptions.Where(c => c.UserId == currentUserId.Value).ToList();
            return View("PersonalReport", consumptions);
        }

        [HttpGet]
        public ActionResult OfficeRatings()
        {
            return View(db.Consumptions.ToList());
        }

    }
}
