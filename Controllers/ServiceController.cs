using System.Linq;
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
            var values = _travelContext.ServiceInnerServices.ToList();

            return PartialView(values);
        }

        public PartialViewResult PartialOuterService()
        {
            return PartialView();
        }
    }
}