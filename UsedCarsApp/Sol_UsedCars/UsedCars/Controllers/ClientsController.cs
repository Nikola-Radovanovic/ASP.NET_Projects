using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.MappingViews;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UsedCars.Models;
using UsedCars.Models.CreatedModels;
using UsedCars.Models.CustomValidation;

namespace UsedCars.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ClientsController : Controller
    {
        private readonly ApplicationDbContext _context;
        
        public ClientsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpGet]
        public ActionResult AllClients()
        {
            var clients = _context.Clients.ToList();

            return View(clients);
        }

        public ActionResult ClientFormCreate()
        {
            return View("ClientFormCreate");
        }

        public ActionResult ClientFormUpdate(int Id)
        {
            var client = _context.Clients.FirstOrDefault(n => n.Id == Id);

            if (client == null)
            {
                return HttpNotFound();
            }

            return View("ClientFormUpdate", client);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateClient(Client client)
        {
            if(client.Id == 0)
            {
                _context.Clients.Add(client);
            }
            else
            {
                var clientInDb = _context.Clients.First(n => n.Id == client.Id);

                clientInDb.Name = client.Name;
                clientInDb.LastName = client.LastName;
                clientInDb.Address = client.Address;
                clientInDb.PostalCode = client.PostalCode;
                clientInDb.City = client.City;
                clientInDb.Country = client.Country;
                clientInDb.Phone = client.Phone;
            }
            
            _context.SaveChanges();

            return RedirectToAction("AllClients", "Clients");
        }

        public ActionResult DeleteClient(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Client client = _context.Clients.Find(Id);
            
            if (client == null)
            {
                return HttpNotFound();
            }
            
            return View(client);
        }

        [HttpPost, ActionName("DeleteClient")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int Id)
        {
            Client client = _context.Clients.Find(Id);

            _context.Clients.Remove(client);
            _context.SaveChanges();
            
            return RedirectToAction("AllClients", "Clients");
        }
    }
}