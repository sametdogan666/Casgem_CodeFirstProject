using System;
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

        [HttpGet]
        public PartialViewResult PartialBooking()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PartialBooking(Booking booking)
        {
            _travelContext.Bookings.Add(booking);
            _travelContext.SaveChanges();

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
            List<Client> clients = new List<Client>();
            clients = _travelContext.Clients.Where(x => x.ClientId == 1).ToList();
            ViewBag.client = clients;
           
            return PartialView();
        }

        public PartialViewResult PartialFooter()
        {
            List<CompanyContact> companyContacts = new List<CompanyContact>();
            companyContacts = _travelContext.CompanyContacts.Where(x => x.Id == 1).ToList();
            ViewBag.comContact = companyContacts;
            return PartialView();
        }

    }
}