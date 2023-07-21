using System.Linq;
using Casgem_CodeFirstProject.DAL.Context;
using System.Web.Mvc;
using Casgem_CodeFirstProject.DAL.Entities;

namespace Casgem_CodeFirstProject.Controllers
{
    [Authorize]
    public class AdminSpecificationController : Controller
    {
        private readonly TravelContext _travelContext = new TravelContext();

        public ActionResult Index()
        {
            ViewBag.countSpecification = _travelContext.Specifications.Count();
            var values = _travelContext.Specifications.ToList();

            return View(values);
        }

        [HttpGet]
        public ActionResult AddSpecification()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSpecification(Specification specification)
        {
            _travelContext.Specifications.Add(specification);
            _travelContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult DeleteSpecification(int id)
        {
            var value = _travelContext.Specifications.Find(id);
            _travelContext.Specifications.Remove(value);
            _travelContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateSpecification(int id)
        {
            var value = _travelContext.Specifications.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateSpecification(Specification specification)
        {
            var values = _travelContext.Specifications.Find(specification.SpecificationId);
            values.SpecificationTitle = specification.SpecificationTitle;
            values.SpecificationDescription = specification.SpecificationDescription;
            values.SpecificationImageUrl = specification.SpecificationImageUrl;
            _travelContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}