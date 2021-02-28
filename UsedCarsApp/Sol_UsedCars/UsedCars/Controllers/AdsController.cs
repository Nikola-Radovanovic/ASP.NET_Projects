using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UsedCars.Models;
using UsedCars.Models.CreatedModels;
using UsedCars.ViewModels;
using PagedList;

namespace UsedCars.Controllers
{
    [Authorize]
    public class AdsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [AllowAnonymous]
        public ActionResult AllAds()
        {
            var ads = _context.Ads.Include(n => n.Client)
                                  .Include(n => n.Car)
                                  .Include(n => n.Car.Brand).ToList();

            if (User.Identity.IsAuthenticated || User.IsInRole("Admin"))
            {
                return View("AllAds", ads);
            }

            return View("AllAdsAnonymous", ads);
        }

        public ActionResult AdFormCreate()
        {
            var viewModel = new AdFormViewModel()
            {
                Clients = _context.Clients.ToList(),
                Cars = _context.Cars.ToList()
            };

            return View("AdFormCreate", viewModel);
        }

        public ActionResult AdFormUpdate(int id)
        {
            var ad = _context.Ads.Include(a => a.Car)
                                 .Include(a => a.Car.Brand)
                                 .FirstOrDefault(a => a.Id == id);

            if (ad == null)
            {
                HttpNotFound();
            }

            return View("AdFormUpdate", ad);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrUpdateAd(Ad ad)
        {
            var viewModel = new AdFormViewModel()
            {
                Ad = new Ad(),
                Cars = _context.Cars.ToList(),
                Clients = _context.Clients.ToList()
            };

            if (ad.Id == 0)                       
            {
                if (!ModelState.IsValid)
                {
                    return View("AdFormCreate", viewModel);
                }

                _context.Ads.Add(ad);
            }
            else
            {
                var adInDb = _context.Ads.First(a => a.Id == ad.Id);

                if (!ModelState.IsValid)
                {
                    return View("AdFormUpdate", adInDb);
                }

                adInDb.Description = ad.Description;
            }

            _context.SaveChanges();

            return RedirectToAction("AdDetails", "Ads", new { ad.Id });
        }

        [AllowAnonymous]
        public ActionResult AdDetails(int Id)
        {
            var ad = _context.Ads.Include(a => a.Car)
                                 .Include(a => a.Client)
                                 .Include(a => a.Car.Brand)
                                 .Include(a => a.Car.Color)
                                 .Include(a => a.Car.YearMake)
                                 .Include(a => a.Car.CarBodyStyle)
                                 .Include(a => a.Car.Fuel)
                                 .FirstOrDefault(a => a.Id == Id);

            return View(ad);
        }

        public ActionResult DeleteAd(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Ad ad = _context.Ads.Include(a => a.Car.Brand).FirstOrDefault(a => a.Id == Id);

            if (ad == null)
            {
                return HttpNotFound();
            }

            return View(ad);
        }

        [HttpPost, ActionName("DeleteAd")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int Id)
        {
            Ad ad = _context.Ads.Find(Id);

            _context.Ads.Remove(ad);
            _context.SaveChanges();

            return RedirectToAction("AllAds", "Ads");
        }
    }
}