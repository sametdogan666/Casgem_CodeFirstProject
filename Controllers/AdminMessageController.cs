using System.Linq;
using System.Web.Mvc;
using Casgem_CodeFirstProject.DAL.Context;

namespace Casgem_CodeFirstProject.Controllers
{
    [Authorize]
    public class AdminMessageController : Controller
    {
        private readonly TravelContext _travelContext = new TravelContext();

        public ActionResult Index()
        {
            var values = _travelContext.Contacts.ToList();

            return View(values);
        }

        public ActionResult DeleteMessage(int id)
        {
            var value = _travelContext.Contacts.Find(id);
            _travelContext.Contacts.Remove(value);
            _travelContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult MessageDetails(int id)
        {
            var value = _travelContext.Contacts.Find(id);
            return View(value);
        }
    }
}