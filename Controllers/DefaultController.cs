using System.Linq;
using System.Web.Mvc;
using Casgem_CodeFirstProject.DAL.Context;

namespace Casgem_CodeFirstProject.Controllers
{
    public class DefaultController : Controller
    {
        TravelContext _travelContext = new TravelContext();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }

        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }

        public PartialViewResult PartialMainFeature()
        {
            return PartialView();
        }

        public PartialViewResult PartialBooking()
        {
            return PartialView();
        }

        public PartialViewResult PartialDestinations()
        {
            return PartialView();
        }

        public PartialViewResult PartialTopDestinations()
        {
            var values = _travelContext.Destinations.ToList();

            return PartialView(values);
        }

        public PartialViewResult PartialExplore()
        {
            return PartialView();
        }

        public PartialViewResult PartialClient()
        {
            return PartialView();
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

    }
}