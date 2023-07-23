using Casgem_CodeFirstProject.DAL.Context;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class ServiceController : Controller
    {
        private readonly TravelContext _travelContext = new TravelContext();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialInnerService()
        {
            return PartialView();
        }

        public PartialViewResult PartialOuterService()
        {
            return PartialView();
        }
    }
}