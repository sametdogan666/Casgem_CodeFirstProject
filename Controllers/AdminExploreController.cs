using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System.Linq;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    [Authorize]
    public class AdminExploreController : Controller
    {
        private readonly TravelContext _travelContext = new TravelContext();

        public ActionResult Index()
        {
            ViewBag.countExplore = _travelContext.Explores.Count();

            var values = _travelContext.Explores.ToList();

            return View(values);
        }

        [HttpGet]
        public ActionResult AddExplore()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddExplore(Explore explore)
        {
            _travelContext.Explores.Add(explore);
            _travelContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult DeleteExplore(int id)
        {
            var value = _travelContext.Explores.Find(id);
            _travelContext.Explores.Remove(value);
            _travelContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateExplore(int id)
        {
            var value = _travelContext.Explores.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateExplore(Explore explore)
        {
            var values = _travelContext.Explores.Find(explore.Id);
            values.SmallTitle = explore.SmallTitle;
            values.Title = explore.Title;
            values.Description = explore.Description;
            values.ImageUrl = explore.ImageUrl;
            _travelContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}