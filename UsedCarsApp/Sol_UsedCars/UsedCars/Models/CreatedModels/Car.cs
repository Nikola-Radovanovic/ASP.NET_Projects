using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UsedCars.Models.CreatedModels
{
    public class Car
    {
        public int Id { get; set; }

        public virtual ICollection<Ad> Ads { get; set; }

        [Required(ErrorMessage = "Enter model name")]
        [StringLength(40)]
        public string Model { get; set; }

        [Required(ErrorMessage = "Enter kilometers")]
        [Range(0, int.MaxValue, ErrorMessage = "Enter valid value for the mileage")]
        [Display(Name = "Kilometers")]
        public int? Kilometers { get; set; }

        [Required(ErrorMessage = "Enter cubic capacity")]
        [Range(0, int.MaxValue, ErrorMessage = "Enter valid value for the cubic capacity")]
        [Display(Name = "Capacity(cm3)")]
        public int? CubicCapacity { get; set; }

        [Required(ErrorMessage = "Enter horse power")]
        [Range(0, int.MaxValue, ErrorMessage = "Enter valid value for the horse power")]
        [Display(Name = "Power(HP)")]
        public int? HorsePower { get; set; }

        [Required(ErrorMessage = "Enter car price")]
        [Range(0, int.MaxValue)]
        public int? Price { get; set; }

        //PopulatedTables
        public Brand Brand { get; set; }
        [Required(ErrorMessage = "Select car brand")]
        [Display(Name = "Car Brand")]
        public int BrandId { get; set; }

        public Color Color { get; set; }
        [Required(ErrorMessage = "Select car color")]
        [Display(Name = "Color")]
        public int ColorId { get; set; }

        public YearMake YearMake { get; set; }
        [Required(ErrorMessage = "Select the year of production")]
        [Display(Name = "Year of production")]
        public int YearMakeId { get; set; }

        public CarBodyStyle CarBodyStyle { get; set; }
        [Required(ErrorMessage = "Select car body")]
        [Display(Name = "Car Body Style")]
        public int CarBodyStyleId { get; set; }

        public Fuel Fuel { get; set; }
        [Required(ErrorMessage = "Select fuel type")]
        [Display(Name = "Fuel")]
        public int FuelId { get; set; }

        [Display(Name = "First owner")]
        public bool FirstOwner { get; set; }
        
        public bool Warranty { get; set; }
        
        public bool Garaged { get; set; }

        [Display(Name = "Service book")]
        public bool ServiceBook { get; set; }

        [Display(Name = "Spare key")]
        public bool SpareKey { get; set; }
        
        public bool Restaurated { get; set; }
        
        public bool Oldtimer { get; set; }

        [Display(Name = "Adapted for the disabled")]
        public bool AdaptedForTheDisabled { get; set; }

        [Display(Name = "Taxi car")]
        public bool TaxiCar { get; set; }

        [Display(Name = "Test car")]
        public bool TestCar { get; set; }
        
        public bool Tuning { get; set; }
    }
}