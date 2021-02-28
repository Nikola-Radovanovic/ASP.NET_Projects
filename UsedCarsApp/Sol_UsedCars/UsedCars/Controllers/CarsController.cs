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

namespace UsedCars.Controllers
{
    [Authorize]
    public class CarsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CarsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult AllCars()
        {
            var cars = _context.Cars.Include(n => n.Brand)
                                    .Include(n => n.YearMake).ToList();

            return View(cars);
        }

        public ActionResult CarDetails(int Id)
        {
            var car = _context.Cars.Include(n => n.Brand)
                                   .Include(n => n.CarBodyStyle)
                                   .Include(n => n.Color)
                                   .Include(n => n.Fuel)
                                   .Include(n => n.YearMake)
                                   .FirstOrDefault(n => n.Id == Id);

            return View(car);
        }

        public ActionResult CarFormCreate()
        {
            var viewModel = new CarFormViewModel
            {
                Car = new Car(),
                Brands = _context.Brands.ToList(),
                Colors = _context.Colors.ToList(),
                YearMakes = _context.YearMakes.ToList(),
                CarBodyStyles = _context.CarBodyStyles.ToList(),
                Fuels = _context.Fuels.ToList()
            };

            return View("CarFormCreate", viewModel);
        }

        public ActionResult CarFormUpdate(int Id)
        {
            var car = _context.Cars.FirstOrDefault(n => n.Id == Id);

            if (car == null)
            {
                return HttpNotFound();
            }

            var viewModel = new CarFormViewModel()
            {
                Car = car,
                Brands = _context.Brands.ToList(),
                Colors = _context.Colors.ToList(),
                YearMakes = _context.YearMakes.ToList(),
                CarBodyStyles = _context.CarBodyStyles.ToList(),
                Fuels = _context.Fuels.ToList()
            };

            return View("CarFormUpdate", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrUpdateCar(Car car)
        {
            var viewModel = new CarFormViewModel
            {
                Car = new Car(),
                Brands = _context.Brands.ToList(),
                Colors = _context.Colors.ToList(),
                YearMakes = _context.YearMakes.ToList(),
                CarBodyStyles = _context.CarBodyStyles.ToList(),
                Fuels = _context.Fuels.ToList()
            };

            if (car.Id == 0)
            {
                if (!ModelState.IsValid)
                {
                    return View("CarFormCreate", viewModel);
                }

                _context.Cars.Add(car);
            }
            else
            {
                if (!ModelState.IsValid)
                {
                    return View("CarFormUpdate", viewModel);
                }

                var carInDb = _context.Cars.First(n => n.Id == car.Id);

                carInDb.Model = car.Model;
                carInDb.Kilometers = car.Kilometers;
                carInDb.CubicCapacity = car.CubicCapacity;
                carInDb.HorsePower = car.HorsePower;
                carInDb.Price = car.Price;
                carInDb.BrandId = car.BrandId;
                carInDb.ColorId = car.ColorId;
                carInDb.YearMakeId = car.YearMakeId;
                carInDb.FuelId = car.FuelId;
                carInDb.CarBodyStyleId = car.CarBodyStyleId;
                carInDb.FirstOwner = car.FirstOwner;
                carInDb.Warranty = car.Warranty;
                carInDb.Garaged = car.Garaged;
                carInDb.ServiceBook = car.ServiceBook;
                carInDb.SpareKey = car.SpareKey;
                carInDb.Restaurated = car.Restaurated;
                carInDb.Oldtimer = car.Oldtimer;
                carInDb.AdaptedForTheDisabled = car.AdaptedForTheDisabled;
                carInDb.TaxiCar = car.TaxiCar;
                carInDb.TestCar = car.TestCar;
                carInDb.Tuning = car.Tuning;
            }

            _context.SaveChanges();

            return RedirectToAction("CarDetails", "Cars", new { car.Id });
        }

        public ActionResult DeleteCar(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Car car = _context.Cars.Include(c => c.Brand).FirstOrDefault(c => c.Id == Id);

            if (car == null)
            {
                return HttpNotFound();
            }

            return View(car);
        }

        [HttpPost, ActionName("DeleteCar")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int Id)
        {
            Car car = _context.Cars.Find(Id);

            _context.Cars.Remove(car);
            _context.SaveChanges();

            return RedirectToAction("AllCars", "Cars");
        }
    }
}