using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System.Linq;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    [Authorize]
    public class AdminAboutSecondBlogController : Controller
    {
        private readonly TravelContext _travelContext = new TravelContext();

        public ActionResult Index()
        {
            ViewBag.countBlog = _travelContext.AboutSecondBlogs.Count();

            var values = _travelContext.AboutSecondBlogs.ToList();

            return View(values);
        }

        [HttpGet]
        public ActionResult AddBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBlog(AboutSecondBlog blog)
        {
            _travelContext.AboutSecondBlogs.Add(blog);
            _travelContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult DeleteBlog(int id)
        {
            var value = _travelContext.AboutSecondBlogs.Find(id);
            _travelContext.AboutSecondBlogs.Remove(value);
            _travelContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateBlog(int id)
        {
            var value = _travelContext.AboutSecondBlogs.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateBlog(AboutSecondBlog blog)
        {
            var values = _travelContext.AboutSecondBlogs.Find(blog.Id);
            values.Title = blog.Title;
            values.Description = blog.Description;
            values.ImageUrl = blog.ImageUrl;
            _travelContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}