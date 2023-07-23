using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class AboutController : Controller
    {
        private readonly TravelContext _travelContext = new TravelContext();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialFirstBlog()
        {
            List<AboutFirstBlog> aboutFirstBlogs = new List<AboutFirstBlog>();
            aboutFirstBlogs = _travelContext.AboutFirstBlogs.ToList();
            ViewBag.firstBlog = aboutFirstBlogs;

            return PartialView();
        }

        public PartialViewResult PartialSecondBlog()
        {
            List<AboutSecondBlog> aboutSecondBlogs = new List<AboutSecondBlog>();
            aboutSecondBlogs = _travelContext.AboutSecondBlogs.ToList();
            ViewBag.secondBlog = aboutSecondBlogs;
            return PartialView();
        }

        public PartialViewResult PartialThirdBlog()
        {
            List<AboutThirdBlog> aboutThirdBlogs = new List<AboutThirdBlog>();
            aboutThirdBlogs = _travelContext.AboutThirdBlogs.ToList();
            ViewBag.thirdBlog = aboutThirdBlogs;
            return PartialView();
        }

        public PartialViewResult PartialGuides()
        {
            var values = _travelContext.Guides.ToList();
   

            return PartialView(values);
        }
    }
}