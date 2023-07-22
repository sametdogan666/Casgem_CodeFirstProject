using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System.Linq;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    [Authorize]
    public class AdminAboutFirstBlogController : Controller
    {
        private readonly TravelContext _travelContext = new TravelContext();

        public ActionResult Index()
        {

            ViewBag.countBlog = _travelContext.AboutFirstBlogs.Count();

            var values = _travelContext.AboutFirstBlogs.ToList();

            return View(values);
        }

        [HttpGet]
        public ActionResult AddBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBlog(AboutFirstBlog blog)
        {
            _travelContext.AboutFirstBlogs.Add(blog);
            _travelContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult DeleteBlog(int id)
        {
            var value = _travelContext.AboutFirstBlogs.Find(id);
            _travelContext.AboutFirstBlogs.Remove(value);
            _travelContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateBlog(int id)
        {
            var value = _travelContext.AboutFirstBlogs.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateBlog(AboutFirstBlog blog)
        {
            var values = _travelContext.AboutFirstBlogs.Find(blog.Id);
            values.Title = blog.Title;
            values.Description = blog.Description;
            values.ImageUrl = blog.ImageUrl;
            _travelContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}