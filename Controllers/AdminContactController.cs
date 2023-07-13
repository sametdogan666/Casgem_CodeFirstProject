using System.Linq;
using System.Web.Mvc;
using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;

namespace Casgem_CodeFirstProject.Controllers
{
    [Authorize]
    public class AdminContactController : Controller
    {
        private readonly TravelContext _travelContext = new TravelContext();

        public ActionResult Index()
        {
            var values = _travelContext.CompanyContacts.ToList();

            return View(values);
        }

        [HttpGet]
        public ActionResult UpdateContact(int id)
        {
            var value = _travelContext.CompanyContacts.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateContact(CompanyContact companyContact)
        {
            var value = _travelContext.CompanyContacts.Find(companyContact.Id);
            value.Description = companyContact.Description;
            value.PhoneNumber = companyContact.PhoneNumber;
            value.Email = companyContact.Email;
            value.Location = companyContact.Location;
            value.MapLocation = companyContact.MapLocation;
            _travelContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}