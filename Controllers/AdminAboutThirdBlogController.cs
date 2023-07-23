using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System.Linq;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    [Authorize]
    public class AdminAboutThirdBlogController : Controller
    {
        private readonly TravelContext _travelContext = new TravelContext();

        public ActionResult Index()
        {
            ViewBag.countBlog = _travelContext.AboutThirdBlogs.Count();

            var values = _travelContext.AboutThirdBlogs.ToList();

            return View(values);
        }

        [HttpGet]
        public ActionResult AddBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBlog(AboutThirdBlog blog)
        {
            _travelContext.AboutThirdBlogs.Add(blog);
            _travelContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult DeleteBlog(int id)
        {
            var value = _travelContext.AboutThirdBlogs.Find(id);
            _travelContext.AboutThirdBlogs.Remove(value);
            _travelContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateBlog(int id)
        {
            var value = _travelContext.AboutThirdBlogs.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateBlog(AboutThirdBlog blog)
        {
            var values = _travelContext.AboutThirdBlogs.Find(blog.Id);
            values.Title = blog.Title;
            values.Description = blog.Description;
            values.ImageUrl = blog.ImageUrl;
            _travelContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}