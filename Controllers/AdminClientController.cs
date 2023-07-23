using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System.Linq;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    [Authorize]
    public class AdminClientController : Controller
    {
        private readonly TravelContext _travelContext = new TravelContext();
   
        public ActionResult Index()
        {
            ViewBag.countClient = _travelContext.Clients.Count();

            var values = _travelContext.Clients.ToList();

            return View(values);
        }

        [HttpGet]
        public ActionResult AddClient()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddClient(Client client)
        {
            _travelContext.Clients.Add(client);
            _travelContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult DeleteClient(int id)
        {
            var value = _travelContext.Clients.Find(id);
            _travelContext.Clients.Remove(value);
            _travelContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateClient(int id)
        {
            var value = _travelContext.Clients.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateClient(Client client)
        {
            var values = _travelContext.Clients.Find(client.ClientId);
            values.ClientTitle = client.ClientTitle;
            values.ClientDescription = client.ClientDescription;
            values.ClientImageUrl = client.ClientImageUrl;
            _travelContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}