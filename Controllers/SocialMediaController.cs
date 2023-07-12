using Casgem_CodeFirstProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class SocialMediaController : Controller
    {
        private readonly TravelContext _travelContext = new TravelContext();

        public ActionResult Index()
        {
            var values = _travelContext.SocialMedias.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddSocialMedia()
        {
            var values = (from guide in _travelContext.Guides.ToList()
                                           select new SelectListItem
                                           {
                                               Value = guide.GuideId.ToString(),
                                               Text = guide.GuideName
                                           }).ToList();
            ViewBag.v = values;

            return View();
        }
    }
}