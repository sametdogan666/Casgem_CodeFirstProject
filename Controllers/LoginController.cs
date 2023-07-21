using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;

namespace Casgem_CodeFirstProject.Controllers
{
    public class LoginController : Controller
    {
        private readonly TravelContext _travelContext = new TravelContext();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index(Admin admin)
        {
            var value = _travelContext.Admins.FirstOrDefault(x => x.UserName == admin.UserName && x.Password == admin.Password);
            
            if (value != null)
            {
                FormsAuthentication.SetAuthCookie(value.UserName, false);
                Session["userTravel"] = value.UserName.ToString();
                return RedirectToAction("Index", "AdminBooking");
            }
            else
            {
                return View();
            }

        }

        [HttpGet]
        public ActionResult LogOut()
        {
            Session.Clear();

            return RedirectToAction("Index");
        }
    }
}