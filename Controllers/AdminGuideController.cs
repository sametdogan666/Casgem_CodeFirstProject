using System.Linq;
using System.Web.Mvc;
using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;

namespace Casgem_CodeFirstProject.Controllers
{
    [Authorize]
    public class AdminGuideController : Controller
    {
        TravelContext _travelContext = new TravelContext();

        public ActionResult Index()
        {
            var values = _travelContext.Guides.ToList();

            return View(values);
        }

        [HttpGet]
        public ActionResult AddGuide()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddGuide(Guide guide)
        {
            _travelContext.Guides.Add(guide);
            _travelContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult DeleteGuide(int id)
        {
            var value = _travelContext.Guides.Find(id);
            _travelContext.Guides.Remove(value);
            _travelContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateGuide(int id)
        {
            var value = _travelContext.Guides.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateGuide(Guide guide)
        {
            var values = _travelContext.Guides.Find(guide.GuideId);
            values.GuideName = guide.GuideName;
            values.GuideTitle = guide.GuideTitle;
            values.GuideImageUrl = guide.GuideImageUrl;
            _travelContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}