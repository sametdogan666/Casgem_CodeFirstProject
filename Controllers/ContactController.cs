using System;
using System.Linq;
using System.Web.Mvc;
using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;

namespace Casgem_CodeFirstProject.Controllers
{
    public class ContactController : Controller
    {
        private readonly TravelContext _travelContext = new TravelContext();
        public ActionResult Index()
        {
            ViewBag.description = _travelContext.CompanyContacts.Select(x => x.Description).FirstOrDefault();
            ViewBag.phoneNumber = _travelContext.CompanyContacts.Select(x=>x.PhoneNumber).FirstOrDefault();
            ViewBag.email = _travelContext.CompanyContacts.Select(x=>x.Email).FirstOrDefault();
            ViewBag.location = _travelContext.CompanyContacts.Select(x=>x.Location).FirstOrDefault();
            ViewBag.mapLocation = _travelContext.CompanyContacts.Select(x=>x.MapLocation).FirstOrDefault();

            return View();
        }

        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            _travelContext.Contacts.Add(contact);
            contact.MessageDate = DateTime.Now;
            _travelContext.SaveChanges();

            return RedirectToAction("Index", "Default");
        }
    }
}