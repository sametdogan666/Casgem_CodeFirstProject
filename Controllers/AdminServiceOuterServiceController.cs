using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System.Linq;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    [Authorize]
    public class AdminServiceOuterServiceController : Controller
    {
        private readonly TravelContext _travelContext = new TravelContext();

        public ActionResult Index()
        {
            var values = _travelContext.ServiceOuterServices.ToList();

            return View(values);
        }

        [HttpGet]
        public ActionResult AddService()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddService(ServiceOuterService service)
        {
            _travelContext.ServiceOuterServices.Add(service);
            _travelContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult DeleteService(int id)
        {
            var value = _travelContext.ServiceOuterServices.Find(id);
            _travelContext.ServiceOuterServices.Remove(value);
            _travelContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateService(int id)
        {
            var value = _travelContext.ServiceOuterServices.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateService(ServiceOuterService service)
        {
            var values = _travelContext.ServiceOuterServices.Find(service.Id);
            values.Title = service.Title;
            values.Description = service.Description;
            values.ImageUrl = service.ImageUrl;
            _travelContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}