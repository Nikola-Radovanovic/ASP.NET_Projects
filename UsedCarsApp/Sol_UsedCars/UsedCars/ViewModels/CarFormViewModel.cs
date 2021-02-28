using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UsedCars.Models.CreatedModels;

namespace UsedCars.ViewModels
{
    public class CarFormViewModel
    {
        public Car Car { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
        public IEnumerable<Color> Colors { get; set; }
        public IEnumerable<YearMake> YearMakes { get; set; }
        public IEnumerable<CarBodyStyle> CarBodyStyles { get; set; }
        public IEnumerable<Fuel> Fuels { get; set; }
    }
}