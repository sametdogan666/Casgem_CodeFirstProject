using System.Linq;
using Casgem_CodeFirstProject.DAL.Context;
using System.Web.Mvc;
using Casgem_CodeFirstProject.DAL.Entities;

namespace Casgem_CodeFirstProject.Controllers
{
    [Authorize]
    public class AdminServiceInnerServiceController : Controller
    {
        private readonly TravelContext _travelContext = new TravelContext();

        public ActionResult Index()
        {
            var values = _travelContext.ServiceInnerServices.ToList(); 
            return View(values);
        }

        [HttpGet]
        public ActionResult AddService()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddService(ServiceInnerService service)
        {
            _travelContext.ServiceInnerServices.Add(service);
            _travelContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult DeleteService(int id)
        {
            var value = _travelContext.ServiceInnerServices.Find(id);
            _travelContext.ServiceInnerServices.Remove(value);
            _travelContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateService(int id)
        {
            var value = _travelContext.ServiceInnerServices.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateService(ServiceInnerService service)
        {
            var values = _travelContext.ServiceInnerServices.Find(service.Id);
            values.Title = service.Title;
            values.Description = service.Description;
            values.IconClass = service.IconClass;
            _travelContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}