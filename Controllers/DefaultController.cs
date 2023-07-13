using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;

namespace Casgem_CodeFirstProject.Controllers
{
    public class DefaultController : Controller
    {
        private readonly TravelContext _travelContext = new TravelContext();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }

        public PartialViewResult PartialHeader()
        {
            ViewBag.companyPhone = _travelContext.CompanyContacts.Select(x => x.PhoneNumber).FirstOrDefault();
            return PartialView();
        }

        public PartialViewResult PartialMainFeature()
        {
            return PartialView();
        }

        public PartialViewResult PartialBooking()
        {
            return PartialView();
        }

        public PartialViewResult PartialSpecification()
        {
            List<Specification> specifications = new List<Specification>();
            specifications = _travelContext.Specifications.Where(x => x.IsMainFeature == true).ToList();
            ViewBag.specMain = specifications;

            var values = _travelContext.Specifications.Where(x => x.IsMainFeature == false).ToList();
            
            return PartialView(values);
        }

        public PartialViewResult PartialTopDestinations()
        {
            var values = _travelContext.Destinations.OrderByDescending(t => t.DestinationId).Take(3).ToList();

            return PartialView(values);

        }

        public PartialViewResult PartialExplore()
        {
            return PartialView();
        }

        public PartialViewResult PartialClient()
        {
            return PartialView();
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

    }
}