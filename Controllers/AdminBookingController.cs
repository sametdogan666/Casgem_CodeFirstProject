using Casgem_CodeFirstProject.DAL.Context;
using System.Linq;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    [Authorize]
    public class AdminBookingController : Controller
    {
        private readonly TravelContext _travelContext = new TravelContext();
        public ActionResult Index()
        {
            var values = _travelContext.Bookings.ToList();

            return View(values);
        }

        public ActionResult DeleteBooking(int id)
        {
            var value = _travelContext.Bookings.Find(id);
            _travelContext.Bookings.Remove(value);
            _travelContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}